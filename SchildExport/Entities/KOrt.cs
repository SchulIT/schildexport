using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class KOrt
    {
        public KOrt()
        {
            Schueler = new HashSet<Schueler>();
            SchuelerErzAdr = new HashSet<SchuelerErzAdr>();
        }

        public int Id { get; set; }
        public string Plz { get; set; }
        public string Bezeichnung { get; set; }
        public string Kreis { get; set; }
        public short? Sortierung { get; set; }
        public string Sichtbar { get; set; }
        public string Aenderbar { get; set; }
        public string Land { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual ICollection<Schueler> Schueler { get; set; }
        public virtual ICollection<SchuelerErzAdr> SchuelerErzAdr { get; set; }
    }
}
