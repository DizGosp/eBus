using System;
using System.Collections.Generic;

#nullable disable

namespace eBus.WebAPI.Database
{
    public partial class RedVoznje
    {

        public RedVoznje()
        {
            RezervacijaKartes = new HashSet<RezervacijaKarte>();
        }

        public int RedVoznjeId { get; set; }
        public string Naziv { get; set; }
        public string GradPolaska { get; set; }
        public string GradDolaska { get; set; }
        public DateTime? DatumVrijemePolaska { get; set; }
        public DateTime? DatumVrijemeDolaska { get; set; }
        public decimal? Cijena { get; set; }
        public int? AutobusId { get; set; }
        public int? GradPolaskaId { get; set; }
        public int? GradDolaskaId { get; set; }
        public int? KorisnikId { get; set; }

        public virtual Autobu Autobus { get; set; }
        public virtual Gradovi GradDolaskaNavigation { get; set; }
        public virtual Gradovi GradPolaskaNavigation { get; set; }
        public virtual Korisnici Korisnik { get; set; }
        public virtual ICollection<RezervacijaKarte> RezervacijaKartes { get; set; }
    }
}
