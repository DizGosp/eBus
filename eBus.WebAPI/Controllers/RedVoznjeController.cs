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

    public class RedVoznjeController : BaseCRUDController<Model.RedVoznje, RedVoznjeSearchRequest, RedVoznjeUpsertRequest, RedVoznjeUpsertRequest>
    {
        public RedVoznjeController(ICRUDService<RedVoznje, RedVoznjeSearchRequest, RedVoznjeUpsertRequest, RedVoznjeUpsertRequest> service) : base(service)
        {
        }
    }
}
