using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class Stundentafel
    {
        public Stundentafel()
        {
            StundentafelFaecher = new HashSet<StundentafelFaecher>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public int? JahrgangId { get; set; }
        public string Asdjahrgang { get; set; }
        public string Klasse { get; set; }
        public string Sgl { get; set; }
        public int? FachklasseId { get; set; }
        public string Sichtbar { get; set; }
        public int? SchulnrEigner { get; set; }
        public int? Sortierung { get; set; }

        public virtual ICollection<StundentafelFaecher> StundentafelFaecher { get; set; }
    }
}
