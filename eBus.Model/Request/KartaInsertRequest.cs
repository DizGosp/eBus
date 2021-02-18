using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model.Request
{
    public class KartaInsertRequest
    {
        public int? RezervacijaSjedistaId { get; set; }
        public DateTime? DatumIzdavanja { get; set; }
        public string BrojKarte { get; set; }
        public int? VrstaKarteId { get; set; }
    }
}
