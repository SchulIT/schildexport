using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class EigeneSchuleAbtKl
    {
        public int Id { get; set; }
        public int AbteilungId { get; set; }
        public string Klasse { get; set; }
        public string Sichtbar { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual EigeneSchuleAbteilungen Abteilung { get; set; }
        public virtual Versetzung KlasseNavigation { get; set; }
    }
}
