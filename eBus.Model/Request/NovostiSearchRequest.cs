using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model.Request
{
    public class NovostiSearchRequest
    {
        public string Naslov { get; set; }

        public DateTime? DatumObjave { get; set; }
    }
}
