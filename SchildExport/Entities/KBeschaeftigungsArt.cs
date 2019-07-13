using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class KBeschaeftigungsArt
    {
        public KBeschaeftigungsArt()
        {
            SchuelerAllgAdr = new HashSet<SchuelerAllgAdr>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public short? Sortierung { get; set; }
        public string Sichtbar { get; set; }
        public string Aenderbar { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual ICollection<SchuelerAllgAdr> SchuelerAllgAdr { get; set; }
    }
}
