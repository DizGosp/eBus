using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBus.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBus.WebAPI.Controllers
{

    public class UlogeController : BaseCRUDController<Model.Uloge, Model.Uloge, Model.Uloge, Model.Uloge>
    {
        public UlogeController(ICRUDService<Model.Uloge, Model.Uloge, Model.Uloge, Model.Uloge> service) : base(service)
        {
        }
    }
}

