using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBus.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBus.WebAPI.Controllers
{
    public class KartaController : BaseCRUDController<Model.Karta, Model.Request.KartaSearchRequest, Model.Request.KartaInsertRequest, Model.Karta>
    {
        public KartaController(ICRUDService<Model.Karta, Model.Request.KartaSearchRequest, Model.Request.KartaInsertRequest, Model.Karta> service) : base(service)
        {
        }
    }
}