﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model
{
    public class Notifikacije
    {
        public int NotifikacijeId { get; set; }
        public string Naslov { get; set; }
        public DateTime? DatumSlanja { get; set; }
        public int? NovostId { get; set; }
        public bool Procitano { get; set; }

        public virtual Novosti Novost { get; set; }
    }
}
