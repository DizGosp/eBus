using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBus.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBus.WebAPI.Controllers
{
    public class VrstaKarteController : BaseCRUDController<Model.VrstaKarte, Model.VrstaKarte, Model.VrstaKarte, Model.VrstaKarte>
    {
        public VrstaKarteController(ICRUDService<Model.VrstaKarte, Model.VrstaKarte, Model.VrstaKarte, Model.VrstaKarte> service) : base(service)
        {
        }
    }
}