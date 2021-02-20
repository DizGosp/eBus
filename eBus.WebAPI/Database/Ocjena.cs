﻿using System;
using System.Collections.Generic;

#nullable disable

namespace eBus.WebAPI.Database
{
    public partial class Ocjena
    {
        public int OcjenaId { get; set; }
        public int? PutnikId { get; set; }
        public int? AutobusId { get; set; }
        public int? Ocjena1 { get; set; }
        public string Komentar { get; set; }

        public virtual Putnik Putnik { get; set; }
        public virtual Autobu Autobus { get; set; }
    }
}
