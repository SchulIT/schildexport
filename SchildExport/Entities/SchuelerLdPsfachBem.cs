using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerLdPsfachBem
    {
        public int Id { get; set; }
        public int AbschnittId { get; set; }
        public string Asv { get; set; }
        public string Lels { get; set; }
        public string Esf { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual SchuelerLernabschnittsdaten Abschnitt { get; set; }
    }
}
