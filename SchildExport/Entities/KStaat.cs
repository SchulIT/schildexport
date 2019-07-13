using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class KStaat
    {
        public KStaat()
        {
            Schueler = new HashSet<Schueler>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public string StatistikKrz { get; set; }
        public short? Sortierung { get; set; }
        public string Sichtbar { get; set; }
        public string Aenderbar { get; set; }
        public string ExportBez { get; set; }
        public int? SchulnrEigner { get; set; }
        public string Bezeichnung2 { get; set; }

        public virtual ICollection<Schueler> Schueler { get; set; }
    }
}
