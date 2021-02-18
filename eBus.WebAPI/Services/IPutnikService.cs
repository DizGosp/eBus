using eBus.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
    public interface IPutnikService
    {
        Model.Putnici Authenticiraj(string username, string pass);
        Model.Putnici Registracija(PutnikInsertRequest request);
        Model.Putnici GetUser(PutnikSearchRequest request);

    }
}
