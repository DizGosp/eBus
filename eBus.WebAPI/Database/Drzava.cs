using System;
using System.Collections.Generic;

#nullable disable

namespace eBus.WebAPI.Database
{
    public partial class Drzava
    {
        public Drzava()
        {
            Gradovis = new HashSet<Gradovi>();
        }

        public int DrzavaId { get; set; }
        public string NazivDrzave { get; set; }

        public virtual ICollection<Gradovi> Gradovis { get; set; }
    }
}
