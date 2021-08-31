using AutoMapper;
using eBus.Model.Request;
using eBus.WebAPI.Database;
using eBus.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services   
{
    public class KorisniciService : KorisniciServiceInterface
    {
        private readonly eBusContext _db;
        private readonly IMapper _mapper;
        public KorisniciService(eBusContext c, IMapper m) { _db = c; _mapper = m; }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public List<Model.Korisnici> Get()
        {
            var list = _db.Korisnicis.Include(x=>x.KorisniciUloges).ToList();
            return _mapper.Map<List<Model.Korisnici>>(list);
        }
       
        public List<Model.Korisnici> Get(KorisniciSearchRequest request)
        {
            var query = _db.Korisnicis.Include(x=>x.KorisniciUloges).AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.ime));
            }
            if (!string.IsNullOrWhiteSpace(request?.prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.prezime));
            }
            if (!string.IsNullOrWhiteSpace(request?.userName))
            {
                query = query.Where(x => x.KorisnickoIme.StartsWith(request.userName));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Korisnici>>(list);
        }

        public Model.Korisnici GetById(int id)
        {
            return _mapper.Map<Model.Korisnici>(_db.Korisnicis.Find(id));
        }

        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnici>(request);

            if (request.pass != request.confPass)
            {
                throw new UserException("Pasvordi se ne poklapaju!");
            }


            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.pass);

            _db.Korisnicis.Add(entity);
            _db.SaveChanges();

            foreach (var item in request.Uloge)
            {
                var korisniciUloga = new Database.KorisniciUloge();
                korisniciUloga.DatumIzmjene = DateTime.Now;
                korisniciUloga.KorisnikId = entity.KorisnikId;
                korisniciUloga.UlogaId = item;
                _db.KorisniciUloges.Add(korisniciUloga);
            }

            _db.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Update(int id, KorisniciInsertRequest request)
        {
            var kor = _db.Korisnicis.Find(id);
            _mapper.Map(request, kor);
            _db.SaveChanges();

            if (!string.IsNullOrWhiteSpace(request.pass))
            {
                if (request.pass != request.confPass)
                {
                    throw new UserException("Šifre se ne slažu!");
                }
                kor.LozinkaSalt = GenerateSalt();
                kor.LozinkaHash = GenerateHash(kor.LozinkaSalt, request.pass);
            }

            _mapper.Map(request, kor);
            _db.SaveChanges();
            return _mapper.Map<Model.Korisnici>(kor);
        }

        public Model.Korisnici Authenticiraj(string username, string pass)
        {
            var user = _db.Korisnicis.Include(x => x.KorisniciUloges).ThenInclude(x => x.Uloga).FirstOrDefault(x => x.KorisnickoIme == username);


            if (user != null)
            {
                var Hesh = GenerateHash(user.LozinkaSalt, pass);

                if (Hesh == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Korisnici>(user);
                }
                else return null;
            }
            else return null;
        }
    }
}
