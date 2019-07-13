using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerFotos
    {
        public int SchuelerId { get; set; }
        public byte[] Foto { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual Schueler Schueler { get; set; }
    }
}
