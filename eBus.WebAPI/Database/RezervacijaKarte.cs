﻿using System;
using System.Collections.Generic;

#nullable disable

namespace eBus.WebAPI.Database
{
    public partial class RezervacijaKarte
    {
        public int RezervacijaKarteId { get; set; }
        public DateTime? DatumKreiranja { get; set; }
        public DateTime? DatumIsteka { get; set; }
        public bool? Otkazana { get; set; }

        public bool? Placeno { get; set; }
        public string Qrcode { get; set; }
        public int? KartaId { get; set; }
        public int? PutnikId { get; set; }
        public int? RedVoznjeId { get; set; }

        public virtual Kartum Karta { get; set; }
        public virtual Putnik Putnik { get; set; }
        public virtual RedVoznje RedVoznje { get; set; }
    }
}
