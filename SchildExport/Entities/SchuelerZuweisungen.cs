using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerZuweisungen
    {
        public int AbschnittId { get; set; }
        public int FachId { get; set; }
        public string Kursart { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual SchuelerLernabschnittsdaten Abschnitt { get; set; }
    }
}
