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
    public class PutnikNotifikacijeService : BaseCrudeService<Model.PutnikNotifikacije, PutnikNotifikacijeSearchRequest, Database.PutnikNotifikacije, PutnikNotifikacijeUpsertRequest, PutnikNotifikacijeUpsertRequest>
    {
        public PutnikNotifikacijeService(eBusContext _db, IMapper _mapper) : base(_db, _mapper) { }
        

        public override List<Model.PutnikNotifikacije> Get(PutnikNotifikacijeSearchRequest search)
        {
            var query = _db.PutnikNotifikacijes.Include(x => x.Putnik).Include(l => l.Notifikacije).AsQueryable();

            if (search != null)
            {
                if (search.PutnikId.HasValue)
                {
                    query = query.Where(l => l.PutnikId == search.PutnikId.Value);
                }

                if (search.NotifikacijaId.HasValue)
                {
                    query = query.Where(l => l.NotifikacijeId == search.NotifikacijaId.Value);
                }

            }

            var lista = query.ToList();

            return _mapper.Map<List<Model.PutnikNotifikacije>>(lista);
        }
    }
}