using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model.Request
{
    public class RezervacijaInsertRequest
    {
        public int RezervacijaKarteId { get; set; }
        public DateTime? DatumKreiranja { get; set; }
        public DateTime? DatumIsteka { get; set; }
        public bool? Otkazana { get; set; }
        public string Qrcode { get; set; }
        public int? KartaId { get; set; }
        public int? PutnikId { get; set; }
        public int? RedVoznjeId { get; set; }
        public bool Placeno { get; set; }
    }
}
