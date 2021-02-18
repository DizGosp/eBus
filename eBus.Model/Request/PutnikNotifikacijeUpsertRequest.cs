using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model.Request
{
    public class PutnikNotifikacijeUpsertRequest
    {
        public int NotifikacijaId { get; set; }
        public int PutnikId { get; set; }
        public bool Pregledana { get; set; }
    }
}
