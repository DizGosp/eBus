using System;
using System.Collections.Generic;

#nullable disable

namespace eBus.WebAPI.Database
{
    public partial class PutnikNotifikacije
    {
        public int PutnikNotifikacijeId { get; set; }
        public bool? Procitano { get; set; }
        public int? NotifikacijeId { get; set; }
        public int? PutnikId { get; set; }

        public virtual Notifikacije Notifikacije { get; set; }
        public virtual Putnik Putnik { get; set; }
    }
}
