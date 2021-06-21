using AutoMapper;
using eBus.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
    public class RezervacijaKarteService : BaseCrudeService<Model.RezervacijaKarte, Model.Request.RezervacijaSearchRequest, RezervacijaKarte, Model.Request.RezervacijaInsertRequest, Model.RezervacijaKarte>
    {
        public RezervacijaKarteService(eBusContext _db, IMapper mapper) : base(_db, mapper)
        {
        }
        public override List<Model.RezervacijaKarte> Get(Model.Request.RezervacijaSearchRequest search)
        {
            var query = _db.Set<RezervacijaKarte>()
                .Include(x => x.Putnik)
                .Include(x => x.RedVoznje)
                  .Include(x => x.RedVoznje.Autobus)
                .Include(x => x.Karta)
                .AsQueryable();

            if (search.PutnikId != null)
            {
                query = query.Where(x => x.PutnikId == search.PutnikId);
            }
            if (search.RezervacijaId != null)
            {
                query = query.Where(x => x.RezervacijaKarteId == search.RezervacijaId);
            }
            if (search.Platio != null)
            {
                query = query.Where(x => x.Placeno == search.Platio);
            }
            var list = query.ToList();

            return _mapper.Map<List<Model.RezervacijaKarte>>(list);
        }
    }
}