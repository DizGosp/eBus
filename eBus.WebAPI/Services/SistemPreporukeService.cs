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

                if (item.GradPolaskaId==2)
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


            //var putnik = _db.Putniks.Find(request.PutnikId);//Pronadji logovanog putnika
            //var listaAutobusa = _db.Autobus.ToList(); //Lista autobusa
            //var listaAutobusaSaOcjenom = new List<int>(); // Lista autobusa sa ocjenom vecom od ispod određene
            //var listaAutobusaBezOcjene = new List<int>(); // Lista autobusa sa ocjenom manjom od ispod određene
            //var listaPolazista = new List<int>(); // Lista polazišta koje je korisnik ranije odabrao
            //var ratingList = _db.Ocjenas.Include(x => x.Putnik).Include(x => x.RedVoznje).ToList(); //Sve ocjene za logovanog putnika
            //var listRedova = new List<Model.RedVoznje>();  //Lista redova voznje za autobuse sa ocjenom
            //var listRedoviVoznje = new List<Model.RedVoznje>();  //Lista redova voznje za autobuse sa ocjenom i zbirom grada polaska veci od 2

            //float countRatings = 0;
            //int brojacOcjena = 0;

            //SistemPreporuke model = new SistemPreporuke();
            //model.listaPreporuka = new List<Model.RedVoznje>();

            //foreach (var vozilo in listaAutobusa)
            //{
            //    countRatings = 0;
            //    brojacOcjena = 0;

            //    foreach (var r in ratingList)
            //    {
            //        if (vozilo.AutobusId == r.RedVoznjeId && r.PutnikId != putnik.PutnikId)
            //        {
            //            if (r.Ocjena1 >= 3)
            //            {
            //                countRatings += (float)r.Ocjena1; //Dodaje ocjenu vecu od 3
            //                brojacOcjena++; //Povecava brojac dodatih ocjena
            //            }
            //        }
            //    }
            //    float avg = 0;
            //    if (countRatings != 0)
            //    {
            //        avg = (float)(countRatings / brojacOcjena); //Izracunava prosjek, suma/broj ocjena
            //    }
            //    if (avg >= 4)
            //    {

            //        listaAutobusaSaOcjenom.Add(vozilo.AutobusId); //Ako je prosjek ocjene veci od 4 dodaje id autobusa

            //    }
            //    else
            //    {
            //        listaAutobusaBezOcjene.Add(vozilo.AutobusId);
            //    }
            //}

            //foreach (var item in listaAutobusaSaOcjenom)
            //{
            //    var listRed = _db.RedVoznjes.Where(x => x.AutobusId == item).ToList();
            //    foreach (var x in listRed)
            //    {
            //        listRedova.Add(_mapper.Map<Model.RedVoznje>(x)); //Dodaje sve Redove voznji sa autobusima (ocjenom iznad prosjeka)
            //        listaPolazista.Add((int)x.GradPolaskaId); //Dodajemo id od grada polazista
            //    }
            //}

            //foreach (var item in listRedova)
            //{
            //    var brojac = 0;
            //    for (int i = 0; i < listaPolazista.Count; i++)
            //    {
            //        if (item.GradPolaskaId == listaPolazista[i])
            //        {
            //            brojac++;
            //        }
            //    }
            //    if (brojac > 2)
            //    {
            //        listRedoviVoznje.Add(item); //Dodaje redove voznje koji su imali isti grad polaska više od 2x
            //    }

            //}


            //foreach (var item in listRedoviVoznje)
            //{
            //    if (item.DatumVrijemePolaska >= DateTime.Today)
            //        model.listaPreporuka.Add(item);
            //}

            //model.listaPreporuka = model.listaPreporuka.OrderByDescending(r => r.Cijena).ToList();

            //return model;
        }
    }
}