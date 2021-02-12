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
    public class PutnikController : BaseCRUDController<Model.Putnici, PutnikSearchRequest, PutnikUpsertRequest, PutnikUpsertRequest>
    {
        private readonly IPutnikService _putnikSer;
        public PutnikController(ICRUDService<Model.Putnici, PutnikSearchRequest, PutnikUpsertRequest, PutnikUpsertRequest> service, IPutnikService putnik) : base(service)
        {
            _putnikSer = putnik;
        }
        [HttpPost("Registracija")]
        [AllowAnonymous]
        public Model.Putnici Registracija(PutnikInsertRequest request)
        {
            return _putnikSer.Registracija(request);
        }

    }
}