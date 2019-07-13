using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class KOrtsteil
    {
        public KOrtsteil()
        {
            Schueler = new HashSet<Schueler>();
            SchuelerErzAdr = new HashSet<SchuelerErzAdr>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public string Plz { get; set; }
        public short? Sortierung { get; set; }
        public string Sichtbar { get; set; }
        public string Aenderbar { get; set; }
        public int? SchulnrEigner { get; set; }
        public string OrtsteilSchluessel { get; set; }

        public virtual ICollection<Schueler> Schueler { get; set; }
        public virtual ICollection<SchuelerErzAdr> SchuelerErzAdr { get; set; }
    }
}
