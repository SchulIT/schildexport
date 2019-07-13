using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class EigeneSchuleKursart
    {
        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public string InternBez { get; set; }
        public string Kursart { get; set; }
        public string KursartAllg { get; set; }
        public short? Sortierung { get; set; }
        public string Sichtbar { get; set; }
        public string Aenderbar { get; set; }
        public int? SchulnrEigner { get; set; }
    }
}
