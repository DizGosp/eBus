using System;
using System.Collections.Generic;

#nullable disable

namespace eBus.WebAPI.Database
{
    public partial class Korisnici
    {
        public Korisnici()
        {
            KorisniciUloges = new HashSet<KorisniciUloge>();
            Novostis = new HashSet<Novosti>();
            RedVoznjes = new HashSet<RedVoznje>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool? Status { get; set; }
        public byte[] Slika { get; set; }

        public virtual ICollection<KorisniciUloge> KorisniciUloges { get; set; }
        public virtual ICollection<Novosti> Novostis { get; set; }
        public virtual ICollection<RedVoznje> RedVoznjes { get; set; }
    }
}
