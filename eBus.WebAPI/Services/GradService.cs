using AutoMapper;
using eBus.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
    public class GradService : BaseCrudeService<Model.Grad, Model.Grad, Gradovi, Model.Grad, Model.Grad>
    {
        public GradService(eBusContext _db, IMapper mapper) : base(_db, mapper)
        {
        }
    }
}