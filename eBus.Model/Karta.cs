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
        public int? VrstaKarteId { get; set; }


        public override string ToString()
        {
            return "Datum izdavanja: "+DatumIzdavanja.Value.ToString() +" - broj karte: "+BrojKarte;
        }

        public virtual RezervacijaSjedista RezervacijaSjedista { get; set; }
    }
}
