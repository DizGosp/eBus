using AutoMapper;
using eBus.Model;
using eBus.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
    public class VozaciServis : BaseCrudeService<Model.Vozaci, Model.Vozaci, Vozac, Model.Vozaci, Model.Vozaci>
    {
        public VozaciServis(eBusContext _db, IMapper mapper) : base(_db, mapper)
        {
        }
        public override List<Model.Vozaci> Get(Model.Vozaci search)
        {
            var query = _db.Set<Vozac>()
                .AsQueryable();

            if (search?.Status == false)
            {
                query = query.Where(x => x.Status == search.Status);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Vozaci>>(list);
        }
    }
}