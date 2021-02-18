using System;
using System.Collections.Generic;

#nullable disable

namespace eBus.WebAPI.Database
{
    public partial class Autobu
    {
   
        public Autobu()
        {
            RedVoznjes = new HashSet<RedVoznje>();
            RezervacijaSjedista = new HashSet<RezervacijaSjedistum>();
            Ocjenas = new HashSet<Ocjena>();
        }

        public int AutobusId { get; set; }
        public int? VozacId { get; set; }
        public string NazivAutobusa { get; set; }
        public string Klasa { get; set; }
        public int BrojSjedista { get; set; }
        public bool? Status { get; set; }

        public virtual Vozac Vozac { get; set; }
        public virtual ICollection<RedVoznje> RedVoznjes { get; set; }
        public virtual ICollection<RezervacijaSjedistum> RezervacijaSjedista { get; set; }
        public virtual ICollection<Ocjena> Ocjenas { get; set; }
    }
}
