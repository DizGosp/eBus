using AutoMapper;
using eBus.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
    public class RezervacijaSjedistaService : BaseCrudeService<Model.RezervacijaSjedista, Model.RezervacijaSjedista, RezervacijaSjedistum, Model.RezervacijaSjedista, Model.RezervacijaSjedista>
    {
        public RezervacijaSjedistaService(eBusContext _db, IMapper mapper) : base(_db, mapper)
        {
        }

        public override List<Model.RezervacijaSjedista> Get(Model.RezervacijaSjedista search)
        {
            var query = _db.RezervacijaSjedista.Include(x => x.Autobus).AsQueryable();

            if (search != null)
            {
                if (search.AutobusId.HasValue)
                {
                    query = query.Where(x => x.AutobusId == search.AutobusId.Value);
                }
            }

            var lista = query.ToList();

            return _mapper.Map<List<Model.RezervacijaSjedista>>(lista);
        }

    }
}

