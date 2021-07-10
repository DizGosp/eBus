using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBus.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBus.WebAPI.Controllers
{
    public class RezervacijaKarteController : BaseCRUDController<Model.RezervacijaKarte, Model.Request.RezervacijaSearchRequest, Model.Request.RezervacijaInsertRequest, Model.Request.RezervacijaKarteUpdateRequest>
    {
        public RezervacijaKarteController(ICRUDService<Model.RezervacijaKarte, Model.Request.RezervacijaSearchRequest, Model.Request.RezervacijaInsertRequest, Model.Request.RezervacijaKarteUpdateRequest> service) : base(service)
    {

          
        }
}
}