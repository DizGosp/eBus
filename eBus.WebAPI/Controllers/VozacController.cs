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
    public class VozacController : BaseCRUDController<Model.Vozaci, Model.Vozaci, Model.Vozaci, Model.Vozaci>
    {
        public VozacController(ICRUDService<Vozaci, Model.Vozaci, Model.Vozaci, Model.Vozaci> service) : base(service)
        {
        }
    }
}