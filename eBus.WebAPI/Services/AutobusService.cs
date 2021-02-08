using AutoMapper;
using eBus.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
    public class AutobusService:BaseCrudeService<Model.Autobus, Model.Autobus, Autobu, Model.Autobus, Model.Autobus>
    {
        public AutobusService(eBusContext _db, IMapper mapper) : base(_db, mapper)
        {
        }

        public override List<Model.Autobus> Get(Model.Autobus search)
        {
            var query = _db.Set<Autobu>()
                .Include(x => x.Vozac)
                .AsQueryable();

            if (search.Status==false)
            {
                query = query.Where(x => x.Status == search.Status);
            }
            if (search.VozacId !=null )
            {
                query = query.Where(x => x.VozacId == search.VozacId);
            }
            if (search.AutobusId != null)
            {
                query = query.Where(x => x.AutobusId == search.AutobusId);
            }
            if (search.NazivAutobusa != null)
            {
                query = query.Where(x => x.NazivAutobusa == search.NazivAutobusa);
            }
            if (search.Klasa != null)
            {
                query = query.Where(x => x.Klasa == search.Klasa);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Autobus>>(list);
        }

    }
}
