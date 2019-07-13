using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class KAnkreuzfloskeln
    {
        public long Id { get; set; }
        public int SchulnrEigner { get; set; }
        public int FachId { get; set; }
        public string Jahrgang { get; set; }
        public string Floskeltext { get; set; }
        public int? Sortierung { get; set; }
        public int? FachSortierung { get; set; }
        public int? Abschnitt { get; set; }
    }
}
