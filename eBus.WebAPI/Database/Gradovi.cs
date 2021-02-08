using System;
using System.Collections.Generic;

#nullable disable

namespace eBus.WebAPI.Database
{
    public partial class Gradovi
    {
        public Gradovi()
        {
            RedVoznjeGradDolaskaNavigations = new HashSet<RedVoznje>();
            RedVoznjeGradPolaskaNavigations = new HashSet<RedVoznje>();
        }

        public int GradId { get; set; }
        public string NazivGrada { get; set; }
        public int? DrzavaId { get; set; }

        public virtual Drzava Drzava { get; set; }
        public virtual ICollection<RedVoznje> RedVoznjeGradDolaskaNavigations { get; set; }
        public virtual ICollection<RedVoznje> RedVoznjeGradPolaskaNavigations { get; set; }
    }
}
