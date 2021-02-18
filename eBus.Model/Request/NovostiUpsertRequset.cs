using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBus.Model.Request
{
    public class NovostiUpsertRequset
    {
        [Required]
        public string Naslov { get; set; }
        [Required]
        public string Sadrzaj { get; set; }
        public DateTime? DatumObjave { get; set; }
        [Required]
        public int KorisnikId { get; set; }
    }
}
