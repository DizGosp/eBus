using AutoMapper;
using eBus.Model;
using eBus.Model.Request;
using eBus.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Services
{
    public class SistemPreporukeService : ISistemPreporuke
    {

        private readonly eBusContext _db;
        private readonly IMapper _mapper;
        public SistemPreporukeService(eBusContext c, IMapper m) { _db = c; _mapper = m; }


        public Model.SistemPreporuke Get(SistemPreporukeRequest request)
        {

            var putnikList = _db.Putniks.Find(request.PutnikId);
            var redVoznjeList = _db.RedVoznjes.Include(x => x.Autobus).Include(x=>x.GradPolaskaNavigation).ToList();
            var ocjeneList = _db.Ocjenas.Include(y => y.RedVoznje).Include(u => u.Putnik).Include(a=>a.RedVoznje.Autobus).ToList();

            float countOcjene = 0;
            int brojacOcjena = 0;

            SistemPreporuke model = new SistemPreporuke();
            model.listaPreporuka = new List<Model.Autobus>();

            foreach (var item in redVoznjeList)
            {
                countOcjene = 0;
                brojacOcjena = 0;

                if (item.GradPolaskaNavigation.NazivGrada=="Mostar")
                {
                    foreach (var x in ocjeneList)
                    {
                        if (item.RedVoznjeId == x.RedVoznjeId)
                        {
                            if (x.Ocjena1 >= 2)
                            {
                                countOcjene += (float)x.Ocjena1;
                                brojacOcjena++;
                            }
                        }
                    }

                    float avg = 0;
                    if (countOcjene != 0)
                    {
                        avg = (float)(countOcjene / brojacOcjena);
                    }
                    if (avg > 2.5)
                    {
                        model.listaPreporuka.Add(new Model.Autobus
                        {
                            AutobusId=item.Autobus.AutobusId,
                            NazivAutobusa=item.Autobus.NazivAutobusa,
                            Klasa=item.Autobus.Klasa,
                            VozacId=item.Autobus.VozacId
                        });
                       
                    }

                    

                }

                model.listaPreporuka = model.listaPreporuka.OrderByDescending(r=>r.NazivAutobusa).ToList();
               
            }


            return model;

        }
    }
}