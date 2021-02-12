using System;
using System.Collections.Generic;

#nullable disable

namespace eBus.WebAPI.Database
{
    public partial class Kartum
    {
        public Kartum()
        {
            RezervacijaKartes = new HashSet<RezervacijaKarte>();
        }

        public int KartaId { get; set; }
        public int? RezervacijaSjedistaId { get; set; }
        public int? VrstaKarteId { get; set; }
        public string BrojKarte { get; set; }
        public DateTime? DatumIzdavanja { get; set; }

        public virtual RezervacijaSjedistum RezervacijaSjedista { get; set; }
        public virtual VrstaKarte VrstaKarte { get; set; }
        public virtual ICollection<RezervacijaKarte> RezervacijaKartes { get; set; }
    }
}
