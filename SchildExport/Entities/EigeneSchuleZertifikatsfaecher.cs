using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class EigeneSchuleZertifikatsfaecher
    {
        public int ZertifikatId { get; set; }
        public int SchulnrEigner { get; set; }
        public string Kuerzel { get; set; }
        public string Klartext { get; set; }
        public string Lernfelder { get; set; }
        public int? MaxPunkte { get; set; }
        public int? Sortierung { get; set; }
    }
}
