using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBus.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBus.WebAPI.Controllers
{
    public class RezervacijaSjedistaController : BaseCRUDController<Model.RezervacijaSjedista, Model.RezervacijaSjedista, Model.RezervacijaSjedista, Model.RezervacijaSjedista>
    {
        public RezervacijaSjedistaController(ICRUDService<Model.RezervacijaSjedista, Model.RezervacijaSjedista, Model.RezervacijaSjedista, Model.RezervacijaSjedista> service) : base(service)
        {
        }
    }
}