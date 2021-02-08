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
    public class GradController : BaseCRUDController<Model.Grad, Model.Grad, Model.Grad, Model.Grad>
    {
        public GradController(ICRUDService<Grad, Model.Grad, Model.Grad, Model.Grad> service) : base(service)
        {
        }
    }
}
