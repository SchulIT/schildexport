using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class KKlassenOrgForm
    {
        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public string StatistikKrz { get; set; }
        public short? Sortierung { get; set; }
        public string Sichtbar { get; set; }
        public string Aenderbar { get; set; }
    }
}
