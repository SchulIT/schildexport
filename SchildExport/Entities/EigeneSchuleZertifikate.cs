using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class EigeneSchuleZertifikate
    {
        public int Id { get; set; }
        public int SchulnrEigner { get; set; }
        public string Kuerzel { get; set; }
        public string Bezeichnung { get; set; }
        public string Fach { get; set; }
        public string Formatvorlage { get; set; }
    }
}
