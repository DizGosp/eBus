using System;
using System.Collections.Generic;

#nullable disable

namespace eBus.WebAPI.Database
{
    public partial class VrstaKarte
    {
        public VrstaKarte()
        {
            Karta = new HashSet<Kartum>();
        }

        public int VrstaKarteId { get; set; }
        public string VrstaKarte1 { get; set; }

        public virtual ICollection<Kartum> Karta { get; set; }
    }
}
