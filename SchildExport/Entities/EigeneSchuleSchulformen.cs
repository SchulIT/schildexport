using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class EigeneSchuleSchulformen
    {
        public int Id { get; set; }
        public string Sgl { get; set; }
        public string SfSgl { get; set; }
        public string Schulform { get; set; }
        public string DoppelQualifikation { get; set; }
        public short? Sortierung { get; set; }
        public string Sichtbar { get; set; }
        public int? Bkindex { get; set; }
        public int? SchulnrEigner { get; set; }
        public string Schulform2 { get; set; }
    }
}
