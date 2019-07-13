using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerBkabschluss
    {
        public int SchuelerId { get; set; }
        public string Zulassung { get; set; }
        public string Bestanden { get; set; }
        public string Zeugnis { get; set; }
        public string ZertifikatBk { get; set; }
        public string ZulassungErwBk { get; set; }
        public string BestandenErwBk { get; set; }
        public string ZulassungBa { get; set; }
        public string BestandenBa { get; set; }
        public string PraktPrfNote { get; set; }
        public string NoteKolloquium { get; set; }
        public string ThemaAbschlussarbeit { get; set; }
        public int? SchulnrEigner { get; set; }
        public string BapVorhanden { get; set; }
        public string NoteFachpraxis { get; set; }

        public virtual Schueler Schueler { get; set; }
    }
}
