using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model
{
    public class Putnici
    {
        public int PutnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }

        public byte[] Slika { get; set; }
        public DateTime? DatumRegistracije { get; set; }
        public DateTime? DatumRodjenja { get; set; }

        public override string ToString()
        {
            return Ime +" "+Prezime;
        }
    }
}
