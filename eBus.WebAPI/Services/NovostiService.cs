using AutoMapper;
using eBus.Model.Request;
using eBus.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
    public class NovostiService : BaseCrudeService<Model.Novosti, NovostiSearchRequest, Database.Novosti, NovostiUpsertRequset, NovostiUpsertRequset>
    {
        public NovostiService(eBusContext _db, IMapper _mapper) : base(_db, _mapper) { }

        public override List<Model.Novosti> Get(NovostiSearchRequest search)
        {
            var query = _db.Novostis.Include(x => x.Korisnik).AsQueryable();

            if (search != null)
            {
                if (!string.IsNullOrWhiteSpace(search.Naslov))
                {
                    query = query.Where(l => l.Naslov.StartsWith(search.Naslov));
                }
                //search.DatumObjave = DateTime.Now;

                if (search.DatumObjave != null)
                {
                    query = query.Where(l => l.DatumObjave.Value.Date == search.DatumObjave.Value.Date);
                }
            }

            var lista = query.OrderByDescending(x => x.DatumObjave).ToList();

            return _mapper.Map<List<Model.Novosti>>(lista);
        }
    }
}
