﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model
{
    public class Grad
    {
        public int GradId { get; set; }
        public string NazivGrada { get; set; }
        public int? DrzavaId { get; set; }
        public virtual Drzava Drzava { get; set; }

        public override string ToString()
        {
            return NazivGrada;
        }
    }
}
