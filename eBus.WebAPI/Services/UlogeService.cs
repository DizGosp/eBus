using AutoMapper;
using eBus.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
    public class UlogeService : BaseCrudeService<Model.Uloge, Model.Uloge, Uloga, Model.Uloge, Model.Uloge>
    {
        public UlogeService(eBusContext _db, IMapper mapper) : base(_db, mapper)
        {
        }

    }
}
