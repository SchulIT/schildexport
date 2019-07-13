using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class KSchwerpunkt
    {
        public KSchwerpunkt()
        {
            FachklassenSchwerpunkte = new HashSet<FachklassenSchwerpunkte>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public short? Sortierung { get; set; }
        public string Sichtbar { get; set; }
        public string Aenderbar { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual ICollection<FachklassenSchwerpunkte> FachklassenSchwerpunkte { get; set; }
    }
}
