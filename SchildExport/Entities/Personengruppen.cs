using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class Personengruppen
    {
        public int Id { get; set; }
        public int SchulnrEigner { get; set; }
        public string Gruppenname { get; set; }
        public string Zusatzinfo { get; set; }
        public string SammelEmail { get; set; }
        public string GruppenArt { get; set; }
        public string Xmlexport { get; set; }
    }
}
