using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model
{
    public class Autobus
    {
        public int? AutobusId { get; set; }
        public int? VozacId { get; set; }
        public string NazivAutobusa { get; set; }
        public string Klasa { get; set; }
        public bool? Status { get; set; }
        public int? BrojSjedista { get; set; }
        public override string ToString()
        {
            return NazivAutobusa;
        }

    }
}
