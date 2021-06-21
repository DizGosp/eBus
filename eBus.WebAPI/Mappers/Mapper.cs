using AutoMapper;
using eBus.Model;
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

            CreateMap<Database.Putnik, Model.Putnici>().ReverseMap();
            CreateMap<Model.Putnici, Model.Request.PutnikSearchRequest>().ReverseMap();
            CreateMap<Model.Putnici, Model.Request.PutnikInsertRequest>().ReverseMap();
            CreateMap<Model.Putnici, Model.Request.PutnikUpsertRequest>().ReverseMap();//Putnik

            CreateMap<Database.Drzava, Model.Drzava>().ReverseMap();
            CreateMap<Database.Drzava, DrzInsRequst>().ReverseMap();//Drzava

            CreateMap<Database.Vozac, Model.Vozaci>().ReverseMap(); //Vozac


            CreateMap<Database.RezervacijaSjedistum, Model.Request.SjedisteInsertRequest>().ReverseMap(); 
            CreateMap<Database.RezervacijaSjedistum, Model.RezervacijaSjedista>().ReverseMap(); //Sjedište

            CreateMap<Database.Kartum, Model.Karta>().ReverseMap();
            CreateMap<Model.Karta, Model.Request.KartaInsertRequest>().ReverseMap();
            CreateMap<Database.Kartum, Model.Request.KartaInsertRequest>().ReverseMap(); //Karta

            CreateMap<Database.VrstaKarte, Model.VrstaKarte>().ReverseMap(); //VrstaKarte

            CreateMap<Database.RezervacijaSjedistum, Model.RezervacijaSjedista>().ReverseMap(); //RezervacijaSjedista

            CreateMap<Database.RezervacijaKarte, Model.RezervacijaKarte>().ReverseMap();
            CreateMap<Database.RezervacijaKarte, Model.Request.RezervacijaInsertRequest>().ReverseMap();
            CreateMap<Model.RezervacijaKarte, Model.Request.RezervacijaInsertRequest>().ReverseMap();//RezervacijaKarte

            CreateMap<Database.Notifikacije, Model.Notifikacije>();
            CreateMap<NotifikacijeUpsertRequest, Database.Notifikacije>(); //Notifikacije

            CreateMap<Database.Novosti, Model.Novosti>();
            CreateMap<NovostiUpsertRequset, Database.Novosti>(); //Novosti

            CreateMap<Database.PutnikNotifikacije, Model.PutnikNotifikacije>();
            CreateMap<PutnikNotifikacijeUpsertRequest, Database.PutnikNotifikacije>(); //PutnikNotifikacije

            CreateMap<Database.Ocjena, Model.Ocjena>();
            CreateMap<OcjenaInsertRequest, Database.Ocjena>(); //Novosti


        }
    }
}
