using AutoMapper;
using eBus.Model.Request;
using eBus.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
    public class DrzavaService : BaseCrudeService<Model.Drzava, Model.Drzava, Drzava, DrzInsRequst, Model.Drzava>
    {
        public DrzavaService(eBusContext _db, IMapper mapper) : base(_db, mapper)
        {
        }
    }
}