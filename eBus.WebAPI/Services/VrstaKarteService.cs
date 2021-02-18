using AutoMapper;
using eBus.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
    public class VrstaKarteService : BaseCrudeService<Model.VrstaKarte, Model.VrstaKarte, VrstaKarte, Model.VrstaKarte, Model.VrstaKarte>
    {
        public VrstaKarteService(eBusContext _db, IMapper mapper) : base(_db, mapper)
        {
        }
        public  List<Model.VrstaKarte> GetVrsta(Model.VrstaKarte search)
        {
            var query = _db.Set<VrstaKarte>().AsQueryable();

            if (search?.VrstaKarteId != null)
            {
                query = query.Where(x => x.VrstaKarteId == search.VrstaKarteId);
            }
            if (search?.VrstaKarte1!= null)
            {
                query = query.Where(x => x.VrstaKarte1 == search.VrstaKarte1);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.VrstaKarte>>(list);
        }
    }
}
