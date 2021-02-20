﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model
{
   public class Novosti
    {
        public int NovostiId { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime? DatumObjave { get; set; }
        public int? KorisnikId { get; set; }

        public int BrojPregleda { get; set; }

        public virtual Korisnici Korisnik { get; set; }

        public override string ToString()
        {
            return Naslov;
        }
    }
}
