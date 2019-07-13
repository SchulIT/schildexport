using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class KZertifikate
    {
        public string Kuerzel { get; set; }
        public string Bezeichnung { get; set; }
        public int SchulnrEigner { get; set; }
    }
}
