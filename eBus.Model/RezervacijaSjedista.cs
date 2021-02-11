using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model
{
    public class RezervacijaSjedista
    {
        public int RezervacijaSjedistaId { get; set; }
        public int? AutobusId { get; set; }
        public int? Red { get; set; }
        public int? Kolona { get; set; }
        public bool? Status { get; set; }

        public virtual Autobus Autobus { get; set; }
        public override string ToString()
        {
            return $"{Autobus} -> red { Red} - kolona {Kolona}";
        }
    }
}
