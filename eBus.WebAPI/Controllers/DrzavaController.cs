using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBus.Model;
using eBus.Model.Request;
using eBus.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBus.WebAPI.Controllers
{
    public class DrzavaController : BaseCRUDController<Model.Drzava, Model.Drzava, DrzInsRequst, Model.Drzava>
    {
        public DrzavaController(ICRUDService<Drzava, Model.Drzava, DrzInsRequst, Model.Drzava> service) : base(service)
        {
        }
    }
}