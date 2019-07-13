using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class FachklassenSchwerpunkte
    {
        public int SchulnrEigner { get; set; }
        public int FachklasseId { get; set; }
        public int SchwerpunktId { get; set; }

        public virtual EigeneSchuleFachklassen Fachklasse { get; set; }
        public virtual KSchwerpunkt Schwerpunkt { get; set; }
    }
}
