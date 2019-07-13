using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class EigeneSchuleTexte
    {
        public int Id { get; set; }
        public int SchulnrEigner { get; set; }
        public string Kuerzel { get; set; }
        public string Inhalt { get; set; }
        public string Beschreibung { get; set; }
        public string Aenderbar { get; set; }
    }
}
