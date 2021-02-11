using System;
using System.Collections.Generic;

namespace eBus.Model
{
    public class Korisnici
    {
      
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public byte[] Slika { get; set; }
        public bool? Status { get; set; }
        public ICollection<KorisniciUloge>KorisniciUloges { get; set; }

        public string OsobniPodaci { get { return $"{Ime} {Prezime}"; } }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }

}

