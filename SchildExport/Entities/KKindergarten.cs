using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class KKindergarten
    {
        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public string Plz { get; set; }
        public string Ort { get; set; }
        public string Strasse { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Bemerkung { get; set; }
        public string Sichtbar { get; set; }
        public int? Sortierung { get; set; }
        public int? SchulnrEigner { get; set; }
    }
}
