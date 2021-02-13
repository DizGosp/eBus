using eBus.Model.Request;
using eBus.WebAPI.Database;
using eBus.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {

        private readonly KorisniciServiceInterface ksi;
        public KorisniciController(KorisniciServiceInterface service)
        {
            ksi = service;
        }


        [HttpGet]
        public ActionResult<List<Model.Korisnici>> Get([FromQuery] KorisniciSearchRequest request)
        {
            return ksi.Get(request);
        }


        [HttpGet("{id}")]
        public Model.Korisnici GetById(int id)
        {
            return ksi.GetById(id);
        }



        [Authorize(Roles = "Admin")]
        [HttpPost]
        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            return ksi.Insert(request);
        }


        [HttpPut("{id}")]
        public Model.Korisnici Update(int id, KorisniciInsertRequest request)
        {
            return ksi.Update(id, request);
        }

    }
}
