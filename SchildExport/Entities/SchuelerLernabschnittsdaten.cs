using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerLernabschnittsdaten
    {
        public SchuelerLernabschnittsdaten()
        {
            SchuelerFehlstunden = new HashSet<SchuelerFehlstunden>();
            SchuelerLdPsfachBem = new HashSet<SchuelerLdPsfachBem>();
            SchuelerLeistungsdaten = new HashSet<SchuelerLeistungsdaten>();
            SchuelerZuweisungen = new HashSet<SchuelerZuweisungen>();
        }

        public int Id { get; set; }
        public int SchuelerId { get; set; }
        public short Jahr { get; set; }
        public short Abschnitt { get; set; }
        public string Bildungsgang { get; set; }
        public short WechselNr { get; set; }
        public short? Jahrgang { get; set; }
        public int? Hochrechnung { get; set; }
        public string SemesterWertung { get; set; }
        public string PruefOrdnung { get; set; }
        public string Klasse { get; set; }
        public short? Verspaetet { get; set; }
        public int? NpvFachId { get; set; }
        public string NpvNoteKrz { get; set; }
        public DateTime? NpvDatum { get; set; }
        public int? NpaaFachId { get; set; }
        public string NpaaNoteKrz { get; set; }
        public DateTime? NpaaDatum { get; set; }
        public int? NpbqFachId { get; set; }
        public string NpbqNoteKrz { get; set; }
        public DateTime? NpbqDatum { get; set; }
        public string VersetzungKrz { get; set; }
        public short? AbschlussArt { get; set; }
        public string AbschlIstPrognose { get; set; }
        public DateTime? Konferenzdatum { get; set; }
        public DateTime? ZeugnisDatum { get; set; }
        public string KlassenLehrer { get; set; }
        public string Asdschulgliederung { get; set; }
        public string Asdjahrgang { get; set; }
        public int? JahrgangId { get; set; }
        public int? FachklasseId { get; set; }
        public int? SchwerpunktId { get; set; }
        public string ZeugnisBem { get; set; }
        public string Schwerbehinderung { get; set; }
        public int? FoerderschwerpunktId { get; set; }
        public string OrgFormKrz { get; set; }
        public string RefPaed { get; set; }
        public string Klassenart { get; set; }
        public int? SumFehlStd { get; set; }
        public int? SumFehlStdU { get; set; }
        public string Wiederholung { get; set; }
        public int? GesamtnoteGs { get; set; }
        public int? GesamtnoteNw { get; set; }
        public string Folgeklasse { get; set; }
        public int? Foerderschwerpunkt2Id { get; set; }
        public string Abschluss { get; set; }
        public string AbschlussB { get; set; }
        public string Dsnote { get; set; }
        public int? AvLeist { get; set; }
        public int? AvZuv { get; set; }
        public int? AvSelbst { get; set; }
        public int? SvVerant { get; set; }
        public int? SvKonfl { get; set; }
        public int? SvKoop { get; set; }
        public string KnLehrer { get; set; }
        public int? SchulnrEigner { get; set; }
        public int? StvKlassenlehrerId { get; set; }
        public string MoeglNpfaecher { get; set; }
        public string Zertifikate { get; set; }
        public DateTime? DatumFhr { get; set; }
        public string PruefAlgoErgebnis { get; set; }
        public string Zeugnisart { get; set; }
        public DateTime? DatumVon { get; set; }
        public DateTime? DatumBis { get; set; }
        public int? FehlstundenGrenzwert { get; set; }

        public virtual EigeneSchuleFachklassen Fachklasse { get; set; }
        public virtual KFoerderschwerpunkt Foerderschwerpunkt { get; set; }
        public virtual EigeneSchuleJahrgaenge JahrgangNavigation { get; set; }
        public virtual Schueler Schueler { get; set; }
        public virtual ICollection<SchuelerFehlstunden> SchuelerFehlstunden { get; set; }
        public virtual ICollection<SchuelerLdPsfachBem> SchuelerLdPsfachBem { get; set; }
        public virtual ICollection<SchuelerLeistungsdaten> SchuelerLeistungsdaten { get; set; }
        public virtual ICollection<SchuelerZuweisungen> SchuelerZuweisungen { get; set; }
    }
}
