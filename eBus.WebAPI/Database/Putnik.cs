using System;
using System.Collections.Generic;

#nullable disable

namespace eBus.WebAPI.Database
{
    public partial class Putnik
    {
        public Putnik()
        {
            Ocjenas = new HashSet<Ocjena>();
            PutnikNotifikacijes = new HashSet<PutnikNotifikacije>();
            RezervacijaKartes = new HashSet<RezervacijaKarte>();
        }

        public int PutnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public DateTime? DatumRegistracije { get; set; }
        public DateTime? DatumRodjenja { get; set; }

        public virtual ICollection<Ocjena> Ocjenas { get; set; }
        public virtual ICollection<PutnikNotifikacije> PutnikNotifikacijes { get; set; }
        public virtual ICollection<RezervacijaKarte> RezervacijaKartes { get; set; }
    }
}
