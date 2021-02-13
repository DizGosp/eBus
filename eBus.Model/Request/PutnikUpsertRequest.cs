using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBus.Model.Request
{
    public class PutnikUpsertRequest
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(4)]
        public string KorisnickoIme { get; set; }

        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public byte[] Slika { get; set; }

        public string Lozinka { get; set; }
        public string PotvrdiLozinku { get; set; }
    }
}
