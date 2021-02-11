using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model
{
    public class Karta
    {
        public int KartaId { get; set; }
        public int? RezervacijaSjedistaId { get; set; }
        public DateTime? DatumIzdavanja { get; set; }
        public string BrojKarte { get; set; }
        public DateTime? VrijemePolaska { get; set; }
        public DateTime? VrijemeDolaska { get; set; }

        //public virtual RezervacijaSjedistum RezervacijaSjedista { get; set; }
    }
}
