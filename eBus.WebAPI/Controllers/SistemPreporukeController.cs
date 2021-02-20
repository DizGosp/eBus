using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBus.Model.Request;
using eBus.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBus.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SistemPreporukeController : ControllerBase
    {
        private readonly ISistemPreporuke _service;
        public SistemPreporukeController(ISistemPreporuke service)
        {
            _service = service;
        }
       
        [HttpGet]
        public ActionResult <Model.SistemPreporuke> Get([FromQuery] SistemPreporukeRequest request)
        {
            return _service.Get(request);
        }

    }
}
