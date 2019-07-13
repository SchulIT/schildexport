using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class KReligion
    {
        public KReligion()
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
        public string ZeugnisBezeichnung { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual ICollection<Schueler> Schueler { get; set; }
    }
}
