using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Model.Request
{
    public class RedVoznjeSearchRequest
    {
        public string Naziv { get; set; }
        public decimal? Cijena { get; set; }
        public DateTime? DatumVrijemePolaska { get; set; }
        public DateTime? DatumVrijemeDolaska { get; set; }
        public int? AutobusId { get; set; }
        public int? GradPolaskaId { get; set; }
        public int? GradDolaskaId { get; set; }

        
    }
}
