using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model
{
    public class RedVoznje
    {

        public int RedVoznjeId { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumVrijemePolaska { get; set; }
        public DateTime DatumVrijemeDolaska { get; set; }
        public decimal? Cijena { get; set; }
        public int? AutobusId { get; set; }
        public int? GradPolaskaId { get; set; }
        public int? GradDolaskaId { get; set; }
        public int? KorisnikId { get; set; }

        public virtual Autobus Autobus { get; set; }
        public virtual Grad GradDolaskaNavigation { get; set; }
        public virtual Grad GradPolaskaNavigation { get; set; }
        public virtual Korisnici Korisnik { get; set; }

        public string VrijemePolaska { get { return $"{DatumVrijemeDolaska.ToShortTimeString()}"; } }

        public override string ToString()
        {
            return GradPolaskaNavigation + "-" + GradDolaskaNavigation + "/ Datum polaska:" + DatumVrijemePolaska.Date.ToString("dd.MM.yyyy")+"Vrijeme polaska: "+ DatumVrijemePolaska.TimeOfDay.ToString("dd.MM.yyyy")+ "/ Očekivani datum dolaska:" + DatumVrijemeDolaska.Date.ToString("dd.MM.yyyy") + "Vrijeme dolaska: " + DatumVrijemePolaska.TimeOfDay.ToString("dd.MM.yyyy");
        }

    }
}
