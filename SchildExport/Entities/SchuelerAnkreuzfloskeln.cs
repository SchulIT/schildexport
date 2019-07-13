using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerAnkreuzfloskeln
    {
        public long Id { get; set; }
        public int SchuelerId { get; set; }
        public int SchulnrEigner { get; set; }
        public int Jahr { get; set; }
        public int Abschnitt { get; set; }
        public int FloskelId { get; set; }
        public string Stufe1 { get; set; }
        public string Stufe2 { get; set; }
        public string Stufe3 { get; set; }
        public string Stufe4 { get; set; }
        public string Stufe5 { get; set; }

        public virtual Schueler Schueler { get; set; }
    }
}
