using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class LehrerFotos
    {
        public int LehrerId { get; set; }
        public byte[] Foto { get; set; }
        public int? SchulnrEigner { get; set; }
    }
}
