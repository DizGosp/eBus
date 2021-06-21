using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model
{
    public class Ocjena
    {
        public int OcjenaId { get; set; }
        public int? RedVoznjeId { get; set; }
        public int? AutobusId { get; set; }
        public int? Ocjena1 { get; set; }
        public string Komentar { get; set; }

        public virtual Putnici Putnik { get; set; }
        public virtual Autobus Autobus { get; set; }
    }
}
