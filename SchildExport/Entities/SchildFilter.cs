using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchildFilter
    {
        public int Id { get; set; }
        public string Art { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public string Tabellen { get; set; }
        public string ZusatzTabellen { get; set; }
        public string Bedingung { get; set; }
        public string BedingungKlartext { get; set; }
        public int? SchulnrEigner { get; set; }
    }
}
