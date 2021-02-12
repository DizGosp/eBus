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
    public class RedVoznjeService : BaseCrudeService<Model.RedVoznje, RedVoznjeSearchRequest, RedVoznje, RedVoznjeUpsertRequest, RedVoznjeUpsertRequest>
    {
        public RedVoznjeService(eBusContext _db, IMapper mapper) : base(_db, mapper)
        {
        }

        public override List<Model.RedVoznje> Get(RedVoznjeSearchRequest search)
        {
            var query = _db.Set<RedVoznje>()
                .Include(x => x.Autobus)
                .Include(x => x.Korisnik)
                .Include(x => x.GradPolaskaNavigation)
                .Include(x => x.GradDolaskaNavigation)
                .AsQueryable();

            if (search?.AutobusId.HasValue == true && search.AutobusId != 0)
            {
                query = query.Where(x => x.AutobusId == search.AutobusId);
            }
            if (search?.GradPolaskaId.HasValue == true && search.GradPolaskaId != 0)
            {
                query = query.Where(x => x.GradPolaskaId == search.GradPolaskaId);
            }
            if (search?.GradDolaskaId.HasValue == true && search.GradDolaskaId != 0)
            {
                query = query.Where(x => x.GradDolaskaId == search.GradDolaskaId);
            }
            if (search.DatumVrijemePolaska != null && search.DatumVrijemeDolaska != null)
            {
                var startdate = search.DatumVrijemePolaska.Value.Date;
                var enddate = search.DatumVrijemeDolaska.Value.Date;

                query = query.Where(e => e.DatumVrijemePolaska.Value.Date >= startdate && e.DatumVrijemeDolaska.Value.Date <= enddate);
            }


            var list = query.ToList();
            return _mapper.Map<List<Model.RedVoznje>>(list);
        }

    }
}
