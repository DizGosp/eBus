using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model
{
    public class Vozaci
    {
        public int VozacId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Vozacka { get; set; }
        public bool? Status { get; set; }
    }
}
