using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class Usergroups
    {
        public int UgId { get; set; }
        public string UgBezeichnung { get; set; }
        public string UgKompetenzen { get; set; }
        public int? UgNr { get; set; }
        public int? SchulnrEigner { get; set; }
    }
}
