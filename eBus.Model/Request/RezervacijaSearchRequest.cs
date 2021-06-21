using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model.Request
{
    public class RezervacijaSearchRequest
    {
        public int? PutnikId { get; set; }
        public int? RezervacijaId { get; set; }

        public bool? Platio { get; set; }

    }
}
