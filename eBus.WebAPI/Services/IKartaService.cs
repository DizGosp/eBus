using AutoMapper;
using eBus.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
    public class IKartaService : BaseCrudeService<Model.Karta, Model.Karta, Kartum, Model.Karta, Model.Karta>
    {
        public IKartaService(eBusContext _db, IMapper mapper) : base(_db, mapper)
        {
        }
        public override List<Model.Karta> Get(Model.Karta search)
        {
            var query = _db.Set<Kartum>()
                .AsQueryable();

            if (search.DatumIzdavanja.HasValue==true)
            {
                query = query.Where(x => x.DatumIzdavanja == search.DatumIzdavanja);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Karta>>(list);
        }
    }
}