using System;
using System.Collections.Generic;

#nullable disable

namespace eBus.WebAPI.Database
{
    public partial class Novosti
    {
        public Novosti()
        {
            Notifikacijes = new HashSet<Notifikacije>();
        }

        public int NovostiId { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime? DatumObjave { get; set; }
        public int? KorisnikId { get; set; }
        public int? BrojPregleda { get; set; }

        public virtual Korisnici Korisnik { get; set; }
        public virtual ICollection<Notifikacije> Notifikacijes { get; set; }
    }
}
