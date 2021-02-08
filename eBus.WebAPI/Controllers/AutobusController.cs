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

    public class AutobusController : BaseCRUDController<Model.Autobus, Model.Autobus, Model.Autobus, Model.Autobus>
    {
        public AutobusController(ICRUDService<Autobus, Model.Autobus, Model.Autobus, Model.Autobus> service) : base(service)
    {
    }
}
}