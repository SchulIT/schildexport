using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerEinzelleistungen
    {
        public int SchulnrEigner { get; set; }
        public long Id { get; set; }
        public DateTime? Datum { get; set; }
        public int? LehrerId { get; set; }
        public int? ArtId { get; set; }
        public string Bemerkung { get; set; }
        public long? LeistungId { get; set; }
        public string NotenKrz { get; set; }

        public virtual KEinzelleistungen Art { get; set; }
    }
}
