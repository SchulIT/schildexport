using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerNuesdaten
    {
        public int Id { get; set; }
        public int SchuelerId { get; set; }
        public int SchulnrEigner { get; set; }
        public int Jahr { get; set; }
        public int Abschnitt { get; set; }
        public string JahrgangIst { get; set; }
        public string Hauptmerkmal { get; set; }
        public string Nebenmerkmal { get; set; }

        public virtual Schueler Schueler { get; set; }
    }
}
