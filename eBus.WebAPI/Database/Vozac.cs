using System;
using System.Collections.Generic;

#nullable disable

namespace eBus.WebAPI.Database
{
    public partial class Vozac
    {
        public Vozac()
        {
            Autobus = new HashSet<Autobu>();
        }

        public int VozacId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Vozacka { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<Autobu> Autobus { get; set; }
    }
}
