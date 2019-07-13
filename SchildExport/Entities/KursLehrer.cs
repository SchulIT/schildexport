using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class KursLehrer
    {
        public int KursId { get; set; }
        public int LehrerId { get; set; }
        public double? Anteil { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual Kurse Kurs { get; set; }
        public virtual KLehrer Lehrer { get; set; }
    }
}
