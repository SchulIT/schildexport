using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class EigeneSchuleJahrgaenge
    {
        public EigeneSchuleJahrgaenge()
        {
            SchuelerLernabschnittsdaten = new HashSet<SchuelerLernabschnittsdaten>();
        }

        public int Id { get; set; }
        public string InternKrz { get; set; }
        public string Asdjahrgang { get; set; }
        public string Asdbezeichnung { get; set; }
        public string Sichtbar { get; set; }
        public short? Sortierung { get; set; }
        public string IstChronologisch { get; set; }
        public string Spaltentitel { get; set; }
        public string SekStufe { get; set; }
        public string Sgl { get; set; }
        public short? JahrgangNum { get; set; }
        public int? Restabschnitte { get; set; }
        public int? SchulnrEigner { get; set; }
        public int? FolgejahrgangId { get; set; }

        public virtual ICollection<SchuelerLernabschnittsdaten> SchuelerLernabschnittsdaten { get; set; }
    }
}
