using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model.Request
{
    public class OcjenaInsertRequest
    {
        public int? PutnikId { get; set; }
        public int? RedVoznjeId { get; set; }
        public int? Ocjena1 { get; set; }
        public string Komentar { get; set; }
    }
}
