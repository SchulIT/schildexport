using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class KFoerderschwerpunkt
    {
        public KFoerderschwerpunkt()
        {
            Schueler = new HashSet<Schueler>();
            SchuelerLernabschnittsdaten = new HashSet<SchuelerLernabschnittsdaten>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public string StatistikKrz { get; set; }
        public short? Sortierung { get; set; }
        public string Sichtbar { get; set; }
        public string Aenderbar { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual ICollection<Schueler> Schueler { get; set; }
        public virtual ICollection<SchuelerLernabschnittsdaten> SchuelerLernabschnittsdaten { get; set; }
    }
}
