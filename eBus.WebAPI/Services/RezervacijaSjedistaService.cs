using AutoMapper;
using eBus.Model;
using eBus.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
    public class RezervacijaSjedistaService : BaseCrudeService<Model.RezervacijaSjedista, Model.RezervacijaSjedista, RezervacijaSjedistum, Model.Request.SjedisteInsertRequest, Model.RezervacijaSjedista>
    {
        public RezervacijaSjedistaService(eBusContext _db, IMapper mapper) : base(_db, mapper)
        {
        }
        public override List<Model.RezervacijaSjedista> Get(RezervacijaSjedista search)
        {
            var query = _db.Set<RezervacijaSjedistum>()
                .Include(x => x.Autobus)
                .AsQueryable();

            if (search?.AutobusId != null && search.AutobusId != 0)
            {
                query = query.Where(x => x.AutobusId == search.AutobusId);
            }
            if (search?.Status.HasValue == true )
            {
                query = query.Where(x => x.Status == search.Status);
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.RezervacijaSjedista>>(list);
        }

    }
}

