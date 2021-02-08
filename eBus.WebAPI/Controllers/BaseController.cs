using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBus.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBus.WebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BaseController<T,TSearh> : ControllerBase
    {
        private readonly IService<T,TSearh> _service;
        public BaseController(IService<T,TSearh> service)
        {
            _service = service;
        }

        [HttpGet]
        public List<T> Get([FromQuery]TSearh request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _service.GetById(id);
        }

    }
}
