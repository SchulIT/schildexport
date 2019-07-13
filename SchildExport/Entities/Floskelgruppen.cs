using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class Floskelgruppen
    {
        public int SchulnrEigner { get; set; }
        public string Kuerzel { get; set; }
        public string Bezeichnung { get; set; }
        public string Hauptgruppe { get; set; }
        public int? Farbe { get; set; }
    }
}
