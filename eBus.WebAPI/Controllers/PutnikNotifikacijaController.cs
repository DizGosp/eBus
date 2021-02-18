using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBus.Model;
using eBus.Model.Request;
using eBus.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBus.WebAPI.Controllers
{

    public class PutnikNotifikacijaController : BaseCRUDController<Model.PutnikNotifikacije, PutnikNotifikacijeSearchRequest, PutnikNotifikacijeUpsertRequest, PutnikNotifikacijeUpsertRequest>
    {
        public PutnikNotifikacijaController(ICRUDService<PutnikNotifikacije, PutnikNotifikacijeSearchRequest, PutnikNotifikacijeUpsertRequest, PutnikNotifikacijeUpsertRequest> service) : base(service)
        {
        }
    }
}