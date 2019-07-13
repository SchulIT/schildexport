using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerAbgaenge
    {
        public int Id { get; set; }
        public int SchuelerId { get; set; }
        public string BemerkungIntern { get; set; }
        public string AbgangsSchulform { get; set; }
        public string AbgangsBeschreibung { get; set; }
        public string OrganisationsformKrz { get; set; }
        public string AbgangsSchule { get; set; }
        public string AbgangsSchuleAnschr { get; set; }
        public string AbgangsSchulNr { get; set; }
        public string Lsjahrgang { get; set; }
        public string LsentlassArt { get; set; }
        public string LsschulformSim { get; set; }
        public DateTime? LsschulEntlassDatum { get; set; }
        public string Lsversetzung { get; set; }
        public string Lssgl { get; set; }
        public string LsfachklKennung { get; set; }
        public string LsfachklSim { get; set; }
        public string FuerSimexport { get; set; }
        public DateTime? LsbeginnDatum { get; set; }
        public string LsbeginnJahrgang { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual Schueler Schueler { get; set; }
    }
}
