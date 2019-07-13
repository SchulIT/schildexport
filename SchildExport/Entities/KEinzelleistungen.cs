using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class KEinzelleistungen
    {
        public KEinzelleistungen()
        {
            SchuelerEinzelleistungen = new HashSet<SchuelerEinzelleistungen>();
        }

        public int Id { get; set; }
        public int SchulnrEigner { get; set; }
        public string Bezeichnung { get; set; }
        public int? Sortierung { get; set; }
        public string Sichtbar { get; set; }
        public double? Gewichtung { get; set; }

        public virtual ICollection<SchuelerEinzelleistungen> SchuelerEinzelleistungen { get; set; }
    }
}
