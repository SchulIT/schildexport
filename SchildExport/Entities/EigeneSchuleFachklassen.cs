using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class EigeneSchuleFachklassen
    {
        public EigeneSchuleFachklassen()
        {
            FachklassenSchwerpunkte = new HashSet<FachklassenSchwerpunkte>();
            SchuelerLernabschnittsdaten = new HashSet<SchuelerLernabschnittsdaten>();
        }

        public int Id { get; set; }
        public short? Bkindex { get; set; }
        public string Fks { get; set; }
        public string Ap { get; set; }
        public string Bezeichnung { get; set; }
        public short? Sortierung { get; set; }
        public string Sichtbar { get; set; }
        public string Aenderbar { get; set; }
        public string Kennung { get; set; }
        public string FksApSim { get; set; }
        public string BkindexTyp { get; set; }
        public string BeschreibungW { get; set; }
        public string Status { get; set; }
        public int? SchulnrEigner { get; set; }
        public string Lernfelder { get; set; }
        public int? DqrNiveau { get; set; }
        public string Ebene1Klartext { get; set; }
        public string Ebene2Klartext { get; set; }
        public string Ebene3Klartext { get; set; }

        public virtual ICollection<FachklassenSchwerpunkte> FachklassenSchwerpunkte { get; set; }
        public virtual ICollection<SchuelerLernabschnittsdaten> SchuelerLernabschnittsdaten { get; set; }
    }
}
