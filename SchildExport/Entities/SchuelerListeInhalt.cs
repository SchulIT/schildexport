using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerListeInhalt
    {
        public int ListeId { get; set; }
        public int SchuelerId { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual SchuelerListe Liste { get; set; }
        public virtual Schueler Schueler { get; set; }
    }
}
