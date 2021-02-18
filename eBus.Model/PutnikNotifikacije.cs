using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model
{
    public class PutnikNotifikacije
    {
        public int Id { get; set; }
        public int NotifikacijaId { get; set; }
        public int PutnikId { get; set; }
        public bool Pregledana { get; set; }

        public virtual Notifikacije Notifikacija { get; set; }
        public virtual Putnici Putnik { get; set; }
    }
}
