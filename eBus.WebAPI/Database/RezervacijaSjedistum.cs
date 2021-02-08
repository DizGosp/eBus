using System;
using System.Collections.Generic;

#nullable disable

namespace eBus.WebAPI.Database
{
    public partial class RezervacijaSjedistum
    {
        public RezervacijaSjedistum()
        {
            Karta = new HashSet<Kartum>();
        }

        public int RezervacijaSjedistaId { get; set; }
        public int? AutobusId { get; set; }
        public int? Red { get; set; }
        public int? Kolona { get; set; }
        public bool? Status { get; set; }

        public virtual Autobu Autobus { get; set; }
        public virtual ICollection<Kartum> Karta { get; set; }
    }
}
