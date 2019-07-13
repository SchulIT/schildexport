using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class KSchulfunktionen
    {
        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public int? Sortierung { get; set; }
        public string Sichtbar { get; set; }
        public int? SchulnrEigner { get; set; }
    }
}
