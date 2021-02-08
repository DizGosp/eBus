using System;
using System.Collections.Generic;

#nullable disable

namespace eBus.WebAPI.Database
{
    public partial class Notifikacije
    {
        public Notifikacije()
        {
            PutnikNotifikacijes = new HashSet<PutnikNotifikacije>();
        }

        public int NotifikacijeId { get; set; }
        public string Naslov { get; set; }
        public DateTime? DatumSlanja { get; set; }
        public bool? Procitano { get; set; }
        public int? NovostiId { get; set; }

        public virtual Novosti Novosti { get; set; }
        public virtual ICollection<PutnikNotifikacije> PutnikNotifikacijes { get; set; }
    }
}
