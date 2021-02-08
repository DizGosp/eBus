using AutoMapper;
using eBus.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Mappers
{
    public class Mapper :Profile
    {
        public Mapper() 
        {
            CreateMap<Database.Korisnici, Model.Korisnici>().ReverseMap();
            CreateMap<Database.Korisnici, KorisniciInsertRequest>().ReverseMap();
            CreateMap<Model.Korisnici, KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.RedVoznje, Model.RedVoznje > ().ReverseMap();
            CreateMap<Database.Autobu, Model.Autobus>().ReverseMap();
            CreateMap<Database.Gradovi, Model.Grad>().ReverseMap();
            CreateMap<Database.RedVoznje, Model.RedVoznje>().ReverseMap();
            CreateMap<Model.RedVoznje, Model.Request.RedVoznjeSearchRequest>().ReverseMap();
            CreateMap<Model.RedVoznje, Model.Request.RedVoznjeUpsertRequest>().ReverseMap();
            CreateMap<Database.RedVoznje, Model.Request.RedVoznjeUpsertRequest>().ReverseMap();
            CreateMap<Database.KorisniciUloge, Model.KorisniciUloge>().ReverseMap();
            CreateMap<Database.Uloga, Model.Uloge>().ReverseMap();
            CreateMap<Database.Putnik, Model.Korisnici>().ReverseMap();
            CreateMap<Database.Putnik, Model.Putnici>().ReverseMap(); 
            CreateMap<Database.Putnik, Model.Request.PutnikInsertRequest>().ReverseMap();
            CreateMap<Model.Putnici, Model.Request.PutnikInsertRequest>().ReverseMap();
            CreateMap<Database.Drzava, Model.Drzava>().ReverseMap();
            CreateMap<Database.Autobu, Model.Autobus>().ReverseMap();
            CreateMap<Database.Vozac, Model.Vozaci>().ReverseMap();
        }  
    }
}
