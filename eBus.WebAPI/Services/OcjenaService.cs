using AutoMapper;
using eBus.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
    public class OcjenaService : BaseCrudeService<Model.Ocjena, Model.Request.OcjenaSearchRequest, Ocjena, Model.Request.OcjenaInsertRequest, Model.Ocjena>
    {
        public OcjenaService(eBusContext _db, IMapper mapper) : base(_db, mapper)
        {
        }

        public override List<Model.Ocjena> Get(Model.Request.OcjenaSearchRequest search)
        {
            var query = _db.Set<Ocjena>()
                .Include(x => x.Autobus)
                .AsQueryable();

            
            if (search.PutnikId != null)
            {
                query = query.Where(x => x.PutnikId == search.PutnikId);
            }
            if (search.RedVoznjeId != null)
            {
                query = query.Where(x => x.AutobusID == search.RedVoznjeId);
            }
            

            var list = query.ToList();

            return _mapper.Map<List<Model.Ocjena>>(list);
        }

    }
}
