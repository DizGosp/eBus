using AutoMapper;
using eBus.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
    public class IKartaService : BaseCrudeService<Model.Karta, Model.Request.KartaSearchRequest, Kartum, Model.Request.KartaInsertRequest, Model.Karta>
    {
        public IKartaService(eBusContext _db, IMapper mapper) : base(_db, mapper)
        {
        }
        public override List<Model.Karta> Get(Model.Request.KartaSearchRequest search)
        {
            var query = _db.Set<Kartum>()
                .Include(t=>t.RezervacijaSjedista)
                .Include(t => t.RezervacijaSjedista.Autobus)
                .AsQueryable();

            if (search.BrojKarte != null)
            {
                query = query.Where(x => x.BrojKarte == search.BrojKarte);
            }
            if (search.kartaId != null)
            {
                query = query.Where(x => x.KartaId == search.kartaId);
            }
            var list = query.ToList();

            return _mapper.Map<List<Model.Karta>>(list);
        }
    }
}