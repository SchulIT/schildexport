using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class KErzieherArt
    {
        public KErzieherArt()
        {
            SchuelerErzAdr = new HashSet<SchuelerErzAdr>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public short? Sortierung { get; set; }
        public string Sichtbar { get; set; }
        public string Aenderbar { get; set; }
        public string ExportBez { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual ICollection<SchuelerErzAdr> SchuelerErzAdr { get; set; }
    }
}
