using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerGsdaten
    {
        public int SchuelerId { get; set; }
        public int SchulnrEigner { get; set; }
        public int? NoteSprachgebrauch { get; set; }
        public int? NoteLesen { get; set; }
        public int? NoteRechtschreiben { get; set; }
        public int? NoteSachunterricht { get; set; }
        public int? NoteMathematik { get; set; }
        public int? NoteEnglisch { get; set; }
        public int? NoteKunstTextil { get; set; }
        public int? NoteMusik { get; set; }
        public int? NoteSport { get; set; }
        public int? NoteReligion { get; set; }
        public double? DurchschnittsnoteSprache { get; set; }
        public double? DurchschnittsnoteEinfach { get; set; }
        public double? DurchschnittsnoteGewichtet { get; set; }
        public string AnredeKlassenlehrer { get; set; }
        public string NachnameKlassenlehrer { get; set; }
        public string GsKlasse { get; set; }
        public string Bemerkungen { get; set; }
        public string Geschwisterkind { get; set; }
    }
}
