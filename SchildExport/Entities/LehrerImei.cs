using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class LehrerImei
    {
        public int Id { get; set; }
        public int LehrerId { get; set; }
        public int SchulnrEigner { get; set; }
        public string Imei { get; set; }

        public virtual KLehrer Lehrer { get; set; }
    }
}
