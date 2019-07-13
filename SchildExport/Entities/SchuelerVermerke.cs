using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerVermerke
    {
        public int Id { get; set; }
        public int SchuelerId { get; set; }
        public int? VermerkArtId { get; set; }
        public DateTime? Datum { get; set; }
        public string Bemerkung { get; set; }
        public int? SchulnrEigner { get; set; }
        public string AngelegtVon { get; set; }
        public string GeaendertVon { get; set; }

        public virtual Schueler Schueler { get; set; }
        public virtual KVermerkart VermerkArt { get; set; }
    }
}
