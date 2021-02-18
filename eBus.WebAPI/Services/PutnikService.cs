using AutoMapper;
using eBus.Model.Request;
using eBus.WebAPI.Database;
using eBus.WebAPI.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
    public class PutnikService : BaseCrudeService<Model.Putnici, PutnikSearchRequest, Putnik, PutnikUpsertRequest, PutnikUpsertRequest>, IPutnikService
    {
        public PutnikService(eBusContext _db, IMapper _mapper) : base(_db, _mapper) { }

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

        public  List<Model.Korisnici> Get(KorisniciSearchRequest request)
        {
            var query = _db.Korisnicis.AsQueryable();

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
        public  Model.Putnici GetUser(PutnikSearchRequest search)
        {
            var query = _db.Set<Putnik>().AsQueryable();

            if (search?.ime != null)
            {
                query = query.Where(x => x.Ime == search.ime);
            }
            if (search?.prezime != null)
            {
                query = query.Where(x => x.Prezime == search.prezime);
            }
            if (search?.userName != null)
            {
                query = query.Where(x => x.KorisnickoIme == search.userName);
            }
            var list = query.ToList();
            return _mapper.Map<Model.Putnici>(list);
        }
        public Model.Putnici Authenticiraj(string username, string pass)
        {
            var user = _db.Putniks.FirstOrDefault(x => x.KorisnickoIme == username);


            if (user != null)
            {
                var Hesh = GenerateHash(user.LozinkaSalt, pass);

                if (Hesh == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Putnici>(user);
                }
                else return null;
            }
            else return null;
        }

        public Model.Putnici Registracija(PutnikInsertRequest request)
        {
            var entity = _mapper.Map<Database.Putnik>(request);

            if (request.Lozinka != request.PotvrdiLozinku)
            {
                throw new UserException("Pasvordi se ne poklapaju!");
            }


            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Lozinka);

            _db.Putniks.Add(entity);
            _db.SaveChanges();

            return _mapper.Map<Model.Putnici>(entity);
        }
    }
}
