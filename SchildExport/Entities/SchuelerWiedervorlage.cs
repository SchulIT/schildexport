using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerWiedervorlage
    {
        public int Id { get; set; }
        public int SchuelerId { get; set; }
        public int SchulnrEigner { get; set; }
        public string Bemerkung { get; set; }
        public DateTime? AngelegtAm { get; set; }
        public DateTime? WiedervorlageAm { get; set; }
        public DateTime? ErledigtAm { get; set; }
        public int? UserId { get; set; }
        public string Sekretariat { get; set; }
        public string Typ { get; set; }
        public string NichtLoeschen { get; set; }
    }
}
