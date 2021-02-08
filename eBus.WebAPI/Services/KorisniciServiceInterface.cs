using eBus.Model.Request;
using eBus.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
    public interface KorisniciServiceInterface
    {
        List<Model.Korisnici> Get(KorisniciSearchRequest request);
        List<Model.Korisnici> Get();

        Model.Korisnici Insert(KorisniciInsertRequest request);
        Model.Korisnici Update(int id,KorisniciInsertRequest request);

        Model.Korisnici GetById(int id);

        Model.Korisnici Authenticiraj(string username, string pass);

    }
}
