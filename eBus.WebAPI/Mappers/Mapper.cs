using AutoMapper;
using eBus.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnici, Model.Korisnici>().ReverseMap();
            CreateMap<Database.Korisnici, KorisniciInsertRequest>().ReverseMap();
            CreateMap<Model.Korisnici, KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.KorisniciUloge, Model.KorisniciUloge>().ReverseMap();
            CreateMap<Database.Uloga, Model.Uloge>().ReverseMap();//Korisnici i uloge

            CreateMap<Database.RedVoznje, Model.RedVoznje>().ReverseMap();
            CreateMap<Model.RedVoznje, Model.Request.RedVoznjeSearchRequest>().ReverseMap();
            CreateMap<Model.RedVoznje, Model.Request.RedVoznjeUpsertRequest>().ReverseMap();
            CreateMap<Database.RedVoznje, Model.Request.RedVoznjeUpsertRequest>().ReverseMap();  //Red vožnje

            CreateMap<Database.Autobu, Model.Autobus>().ReverseMap();  //Autobus

            CreateMap<Database.Gradovi, Model.Grad>().ReverseMap();  //Grad

            CreateMap<Database.Putnik, Model.Korisnici>().ReverseMap();
            CreateMap<Database.Putnik, Model.Putnici>().ReverseMap();
            CreateMap<Database.Putnik, Model.Request.PutnikInsertRequest>().ReverseMap();
            CreateMap<Database.Putnik, Model.Request.PutnikUpsertRequest>().ReverseMap();
            CreateMap<Model.Putnici, Model.Request.PutnikInsertRequest>().ReverseMap(); //Putnik

            CreateMap<Database.Drzava, Model.Drzava>().ReverseMap();  //Drava

            CreateMap<Database.Vozac, Model.Vozaci>().ReverseMap(); //Vozac

            CreateMap<Database.Kartum, Model.Karta>().ReverseMap(); //Karta

            CreateMap<Database.RezervacijaSjedistum, Model.RezervacijaSjedista>().ReverseMap(); //RezervacijaSjedista


        }
    }
}
