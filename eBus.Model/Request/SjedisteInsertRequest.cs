using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model.Request
{
    public class SjedisteInsertRequest
    {
        public int RezervacijaSjedistaId { get; set; }
        public int? AutobusId { get; set; }
        public int? Red { get; set; }
        public int? Kolona { get; set; }
        public bool? Status { get; set; }
    }
}
