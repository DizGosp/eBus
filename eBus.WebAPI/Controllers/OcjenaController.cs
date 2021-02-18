using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBus.Model;
using eBus.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBus.WebAPI.Controllers
{
    public class OcjenaController : BaseCRUDController<Model.Ocjena, Model.Request.OcjenaSearchRequest, Model.Request.OcjenaInsertRequest, Model.Ocjena>
    {
        public OcjenaController(ICRUDService<Ocjena, Model.Request.OcjenaSearchRequest, Model.Request.OcjenaInsertRequest, Ocjena> service) : base(service)
        {
        }
    }
}