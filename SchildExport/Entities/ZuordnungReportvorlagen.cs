using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class ZuordnungReportvorlagen
    {
        public int Id { get; set; }
        public int SchulnrEigner { get; set; }
        public int JahrgangId { get; set; }
        public string Abschluss { get; set; }
        public string AbschlussBb { get; set; }
        public int? AbschlussArt { get; set; }
        public string VersetzungKrz { get; set; }
        public int? FachklasseId { get; set; }
        public string Reportvorlage { get; set; }
        public string Beschreibung { get; set; }
        public string Gruppe { get; set; }
        public string Zeugnisart { get; set; }
    }
}
