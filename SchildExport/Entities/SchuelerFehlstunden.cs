using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerFehlstunden
    {
        public long Id { get; set; }
        public int SchulnrEigner { get; set; }
        public int AbschnittId { get; set; }
        public DateTime Datum { get; set; }
        public int? FachId { get; set; }
        public double Fehlstd { get; set; }
        public int? VonStd { get; set; }
        public int? BisStd { get; set; }
        public string Entschuldigt { get; set; }
        public int? LehrerId { get; set; }

        public virtual SchuelerLernabschnittsdaten Abschnitt { get; set; }
    }
}
