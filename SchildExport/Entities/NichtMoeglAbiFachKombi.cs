using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class NichtMoeglAbiFachKombi
    {
        public int Fach1Id { get; set; }
        public int Fach2Id { get; set; }
        public int SchulnrEigner { get; set; }
        public string Kursart1 { get; set; }
        public string Kursart2 { get; set; }
        public string Pk { get; set; }
        public int? Sortierung { get; set; }
        public string Phase { get; set; }
        public string Typ { get; set; }
    }
}
