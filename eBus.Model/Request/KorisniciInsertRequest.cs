using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBus.Model.Request
{
    public class KorisniciInsertRequest
    {
        
        
        [Required]
        [MinLength(4)]
        public string Ime { get; set; }
        [Required]
        [MinLength(4)]
        public string Prezime { get; set; }
        public string Email { get; set; }
        [Required]
        [MinLength(4)]
        public string KorisnickoIme { get; set; }
        [Required]
        [MinLength(4)]
        public string pass { get; set; }
        [Required]
        [MinLength(4)]
        public string confPass { get; set; }
        public bool? Status { get; set; }
        public byte[] Slika { get; set; }
        public List<int> Uloge { get; set; } = new List<int>();
    }
}
