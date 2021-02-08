using System;
using System.Collections.Generic;

#nullable disable

namespace eBus.WebAPI.Database
{
    public partial class KorisniciUloge
    {
        public int KorisniciUlogeId { get; set; }
        public int? KorisnikId { get; set; }
        public int? UlogaId { get; set; }
        public DateTime? DatumIzmjene { get; set; }

        public virtual Korisnici Korisnik { get; set; }
        public virtual Uloga Uloga { get; set; }
    }
}
