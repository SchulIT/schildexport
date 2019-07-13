using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class KSchule
    {
        public int Id { get; set; }
        public string SchulNr { get; set; }
        public string Name { get; set; }
        public string SchulformNr { get; set; }
        public string SchulformKrz { get; set; }
        public string SchulformBez { get; set; }
        public string Strasse { get; set; }
        public string Plz { get; set; }
        public string Ort { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Schulleiter { get; set; }
        public short? Sortierung { get; set; }
        public string Sichtbar { get; set; }
        public string Aenderbar { get; set; }
        public string SchulNrSim { get; set; }
        public string Kuerzel { get; set; }
        public string KurzBez { get; set; }
        public int? SchulnrEigner { get; set; }
    }
}
