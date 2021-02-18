using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBus.Model;
using eBus.Model.Request;
using eBus.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBus.WebAPI.Controllers
{
    [AllowAnonymous]
    public class NotifikacijeController : BaseCRUDController<Model.Notifikacije, NotifikacijeSearchRequest, NotifikacijeUpsertRequest, NotifikacijeUpsertRequest>
    {
        public NotifikacijeController(ICRUDService<Notifikacije, NotifikacijeSearchRequest, NotifikacijeUpsertRequest, NotifikacijeUpsertRequest> service) : base(service)
        {
        }
    }
}