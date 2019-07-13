using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class LehrerAbschnittsdaten
    {
        public int LehrerId { get; set; }
        public int Jahr { get; set; }
        public int Abschnitt { get; set; }
        public string Rechtsverhaeltnis { get; set; }
        public string Beschaeftigungsart { get; set; }
        public string Einsatzstatus { get; set; }
        public double? PflichtstdSoll { get; set; }
        public double? UnterrichtsStd { get; set; }
        public double? MehrleistungStd { get; set; }
        public double? EntlastungStd { get; set; }
        public double? AnrechnungStd { get; set; }
        public double? RestStd { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual KLehrer Lehrer { get; set; }
    }
}
