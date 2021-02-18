using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model.Request
{
    public class NotifikacijeUpsertRequest
    {
        public string Naslov { get; set; }
        public DateTime? DatumSlanja { get; set; }
        public int? NovostId { get; set; }
        public bool Procitano { get; set; }
    }
}
