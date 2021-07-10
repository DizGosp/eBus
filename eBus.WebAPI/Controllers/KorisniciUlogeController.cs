using eBus.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Controllers
{
    public class KorisniciUlogeController :BaseCRUDController<Model.KorisniciUloge, Model.KorisniciUloge, Model.KorisniciUloge, Model.KorisniciUloge>
    {
        public KorisniciUlogeController(ICRUDService<Model.KorisniciUloge, Model.KorisniciUloge, Model.KorisniciUloge, Model.KorisniciUloge> service) : base(service)
    {
    }
}
}