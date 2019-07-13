using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class KEntlassGrund
    {
        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public short? Sortierung { get; set; }
        public string Sichtbar { get; set; }
        public string Aenderbar { get; set; }
        public int? SchulnrEigner { get; set; }
    }
}
