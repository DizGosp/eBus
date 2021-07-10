using AutoMapper;
using eBus.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
    public class KorisniciUlogeService : BaseCrudeService<Model.KorisniciUloge, Model.KorisniciUloge, eBus.WebAPI.Database.KorisniciUloge, Model.KorisniciUloge, Model.KorisniciUloge>
    {
        public KorisniciUlogeService(eBusContext _db, IMapper mapper) : base(_db, mapper)
        {
        }

    }
}