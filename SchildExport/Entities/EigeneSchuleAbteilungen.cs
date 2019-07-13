using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class EigeneSchuleAbteilungen
    {
        public EigeneSchuleAbteilungen()
        {
            EigeneSchuleAbtKl = new HashSet<EigeneSchuleAbtKl>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public string AbteilungsLeiter { get; set; }
        public string Sichtbar { get; set; }
        public int? SchulnrEigner { get; set; }
        public string Raum { get; set; }
        public string Email { get; set; }
        public string Durchwahl { get; set; }

        public virtual KLehrer AbteilungsLeiterNavigation { get; set; }
        public virtual ICollection<EigeneSchuleAbtKl> EigeneSchuleAbtKl { get; set; }
    }
}
