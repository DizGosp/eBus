using eBus.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
   public interface ISistemPreporuke
    {
        Model.SistemPreporuke Get(SistemPreporukeRequest request);
    }
}
