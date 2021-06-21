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
    public class NotifikacijaService : BaseCrudeService<Model.Notifikacije, NotifikacijeSearchRequest, Notifikacije, NotifikacijeUpsertRequest, NotifikacijeUpsertRequest>
    {
        public NotifikacijaService(eBusContext _db, IMapper _mapper) : base(_db, _mapper) { }


        public override List<Model.Notifikacije> Get(NotifikacijeSearchRequest search)
        {
            var query = _db.Notifikacijes.Include(x => x.Novosti).AsQueryable();

            if (search != null)
            {
                if (!string.IsNullOrWhiteSpace(search.Naslov))
                {
                    query = query.Where(l => l.Naslov.StartsWith(search.Naslov));
                }

                if (search.NovostId.HasValue)
                {
                    query = query.Where(l => l.NovostiId == search.NovostId.Value);
                }
            }

            var lista = query.OrderByDescending(l => l.DatumSlanja).ToList();

            return _mapper.Map<List<Model.Notifikacije>>(lista);

        }
    }
}