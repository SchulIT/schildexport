using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerListe
    {
        public SchuelerListe()
        {
            SchuelerListeInhalt = new HashSet<SchuelerListeInhalt>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public string Erzeuger { get; set; }
        public string Privat { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual ICollection<SchuelerListeInhalt> SchuelerListeInhalt { get; set; }
    }
}
