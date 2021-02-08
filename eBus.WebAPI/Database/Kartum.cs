using System;
using System.Collections.Generic;

#nullable disable

namespace eBus.WebAPI.Database
{
    public partial class Kartum
    {
        public int KartaId { get; set; }
        public int? RezervacijaSjedistaId { get; set; }
        public string BrojKarte { get; set; }
        public DateTime? DatumIzdavanja { get; set; }
        public DateTime? VrijemePolaska { get; set; }
        public DateTime? VrijemeDolaska { get; set; }

        public virtual RezervacijaSjedistum RezervacijaSjedista { get; set; }
    }
}
