using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerFoerderempfehlungen
    {
        public string GuId { get; set; }
        public int SchuelerId { get; set; }
        public int SchulnrEigner { get; set; }
        public DateTime DatumAngelegt { get; set; }
        public string Klasse { get; set; }
        public int? Jahr { get; set; }
        public int? Abschnitt { get; set; }
        public int? FachId { get; set; }
        public int? LehrerId { get; set; }
        public DateTime? DatumAenderungSchild { get; set; }
        public DateTime? DatumAenderungSchildWeb { get; set; }
        public string Kurs { get; set; }
        public string InhaltlProzessbezKomp { get; set; }
        public string MethodischeKomp { get; set; }
        public string LernArbeitsverhalten { get; set; }
        public string MassnInhaltlProzessbezKomp { get; set; }
        public string MassnMethodischeKomp { get; set; }
        public string MassnLernArbeitsverhalten { get; set; }
        public string VerantwortlichkeitEltern { get; set; }
        public string VerantwortlichkeitSchueler { get; set; }
        public DateTime? ZeitrahmenVonDatum { get; set; }
        public DateTime? ZeitrahmenBisDatum { get; set; }
        public DateTime? UeberpruefungDatum { get; set; }
        public DateTime? NaechstesBeratungsgespraech { get; set; }
        public int? LeistungId { get; set; }
        public int? KursId { get; set; }
        public string EingabeFertig { get; set; }
        public string Faecher { get; set; }
        public string Abgeschlossen { get; set; }

        public virtual Schueler Schueler { get; set; }
    }
}
