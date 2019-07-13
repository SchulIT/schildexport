using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class Schueler
    {
        public Schueler()
        {
            SchuelerAbgaenge = new HashSet<SchuelerAbgaenge>();
            SchuelerAbiFaecher = new HashSet<SchuelerAbiFaecher>();
            SchuelerAnkreuzfloskeln = new HashSet<SchuelerAnkreuzfloskeln>();
            SchuelerBkfaecher = new HashSet<SchuelerBkfaecher>();
            SchuelerErzAdr = new HashSet<SchuelerErzAdr>();
            SchuelerFhrfaecher = new HashSet<SchuelerFhrfaecher>();
            SchuelerFoerderempfehlungen = new HashSet<SchuelerFoerderempfehlungen>();
            SchuelerLernabschnittsdaten = new HashSet<SchuelerLernabschnittsdaten>();
            SchuelerListeInhalt = new HashSet<SchuelerListeInhalt>();
            SchuelerNuesdaten = new HashSet<SchuelerNuesdaten>();
            SchuelerSprachenfolge = new HashSet<SchuelerSprachenfolge>();
            SchuelerTelefone = new HashSet<SchuelerTelefone>();
            SchuelerVermerke = new HashSet<SchuelerVermerke>();
        }

        public int Id { get; set; }
        public string GuId { get; set; }
        public int? SrcId { get; set; }
        public string Idext { get; set; }
        public int? Status { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Zusatz { get; set; }
        public string Geburtsname { get; set; }
        public string Strasse { get; set; }
        public string Plz { get; set; }
        public string OrtAbk { get; set; }
        public int? OrtsteilId { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public short? AktSchuljahr { get; set; }
        public short? AktAbschnitt { get; set; }
        public string Klasse { get; set; }
        public short? Jahrgang { get; set; }
        public string PruefOrdnung { get; set; }
        public DateTime? Geburtsdatum { get; set; }
        public string Geburtsort { get; set; }
        public string Volljaehrig { get; set; }
        public short? Geschlecht { get; set; }
        public string StaatKrz { get; set; }
        public string StaatKrz2 { get; set; }
        public string StaatAbk { get; set; }
        public string Aussiedler { get; set; }
        public int? ReligionId { get; set; }
        public string ReligionAbk { get; set; }
        public DateTime? Religionsabmeldung { get; set; }
        public DateTime? Religionsanmeldung { get; set; }
        public string Bafoeg { get; set; }
        public string Schwerbehinderung { get; set; }
        public int? FoerderschwerpunktId { get; set; }
        public int? SportbefreiungId { get; set; }
        public int? FahrschuelerId { get; set; }
        public int? HaltestelleId { get; set; }
        public string HaltestelleAbk { get; set; }
        public string Asdschulform { get; set; }
        public int? JahrgangId { get; set; }
        public string Asdjahrgang { get; set; }
        public int? FachklasseId { get; set; }
        public string SchulpflichtErf { get; set; }
        public DateTime? Anschreibdatum { get; set; }
        public DateTime? Aufnahmedatum { get; set; }
        public short? Einschulungsjahr { get; set; }
        public int? EinschulungsartId { get; set; }
        public string LsschulNr { get; set; }
        public string LsschulformSim { get; set; }
        public string Lsjahrgang { get; set; }
        public DateTime? LsschulentlassDatum { get; set; }
        public string Lsversetzung { get; set; }
        public string LsfachklKennung { get; set; }
        public string LsfachklSim { get; set; }
        public string Lsentlassgrund { get; set; }
        public string LsentlassArt { get; set; }
        public string Lsklassenart { get; set; }
        public string LsrefPaed { get; set; }
        public string Entlassjahrgang { get; set; }
        public int? EntlassjahrgangId { get; set; }
        public DateTime? Entlassdatum { get; set; }
        public string Entlassgrund { get; set; }
        public string Entlassart { get; set; }
        public string SchulwechselNr { get; set; }
        public DateTime? Schulwechseldatum { get; set; }
        public string Geloescht { get; set; }
        public string Gesperrt { get; set; }
        public DateTime? ModifiziertAm { get; set; }
        public string ModifiziertVon { get; set; }
        public string Markiert { get; set; }
        public string FotoVorhanden { get; set; }
        public string Jva { get; set; }
        public string RefPaed { get; set; }
        public string KeineAuskunft { get; set; }
        public string Lehrer { get; set; }
        public string Beruf { get; set; }
        public string AbschlussDatum { get; set; }
        public string Bemerkungen { get; set; }
        public DateTime? BeginnBildungsgang { get; set; }
        public string Durchschnitt { get; set; }
        public string OrgFormKrz { get; set; }
        public string Klassenart { get; set; }
        public string DurchschnittsNote { get; set; }
        public string Lssgl { get; set; }
        public string Lsschulform { get; set; }
        public string KonfDruck { get; set; }
        public string DsnText { get; set; }
        public string Berufsabschluss { get; set; }
        public int? SchwerpunktId { get; set; }
        public string LssglSim { get; set; }
        public string BerufsschulpflErf { get; set; }
        public int? StatusNsj { get; set; }
        public int? FachklasseNsjId { get; set; }
        public double? Buchkonto { get; set; }
        public string VerkehrsspracheFamilie { get; set; }
        public int? JahrZuzug { get; set; }
        public string DauerKindergartenbesuch { get; set; }
        public string VerpflichtungSprachfoerderkurs { get; set; }
        public string TeilnahmeSprachfoerderkurs { get; set; }
        public string Schulbuchgeldbefreit { get; set; }
        public string Autist { get; set; }
        public string GeburtslandSchueler { get; set; }
        public string GeburtslandVater { get; set; }
        public string GeburtslandMutter { get; set; }
        public string UebergangsempfehlungJg5 { get; set; }
        public string ErsteSchulformSi { get; set; }
        public int? JahrWechselSi { get; set; }
        public int? JahrWechselSii { get; set; }
        public string Migrationshintergrund { get; set; }
        public int? Foerderschwerpunkt2Id { get; set; }
        public int? SortierungKlasse { get; set; }
        public string ExterneSchulnr { get; set; }
        public int? KindergartenId { get; set; }
        public string LetzterBerufsAbschluss { get; set; }
        public string LetzterAllgAbschluss { get; set; }
        public string Land { get; set; }
        public int? AvLeist { get; set; }
        public int? AvZuv { get; set; }
        public int? AvSelbst { get; set; }
        public int? SvVerant { get; set; }
        public int? SvKonfl { get; set; }
        public int? SvKoop { get; set; }
        public string Duplikat { get; set; }
        public string EinschulungsartAsd { get; set; }
        public string Hausnr { get; set; }
        public string Strassenname { get; set; }
        public int? SchulnrEigner { get; set; }
        public string BilingualerZweig { get; set; }
        public string DurchschnittsnoteFhr { get; set; }
        public string DsnFhrText { get; set; }
        public double? Eigenanteil { get; set; }
        public string StaatAbk2 { get; set; }
        public string ZustimmungFoto { get; set; }
        public int? Bkazvo { get; set; }
        public string HatBerufsausbildung { get; set; }
        public string Ausweisnummer { get; set; }
        public string Aosf { get; set; }
        public int? Epjahre { get; set; }
        public string Lsbemerkung { get; set; }
        public string WechselBestaetigt { get; set; }
        public int? DauerBildungsgang { get; set; }
        public DateTime? AnmeldeDatum { get; set; }
        public string MeisterBafoeg { get; set; }
        public string OnlineAnmeldung { get; set; }
        public string Dokumentenverzeichnis { get; set; }
        public string Berufsqualifikation { get; set; }
        public string HausnrZusatz { get; set; }
        public string ZieldifferentesLernen { get; set; }
        public string ZusatzNachname { get; set; }
        public DateTime? EndeEingliederung { get; set; }
        public string SchulEmail { get; set; }
        public DateTime? EndeAnschlussfoerderung { get; set; }

        public virtual KEinschulungsArt Einschulungsart { get; set; }
        public virtual KFahrschuelerArt Fahrschueler { get; set; }
        public virtual KFoerderschwerpunkt Foerderschwerpunkt { get; set; }
        public virtual KHaltestelle Haltestelle { get; set; }
        public virtual Versetzung KlasseNavigation { get; set; }
        public virtual KOrtsteil Ortsteil { get; set; }
        public virtual KOrt PlzNavigation { get; set; }
        public virtual KReligion Religion { get; set; }
        public virtual KSportbefreiung Sportbefreiung { get; set; }
        public virtual KStaat StaatKrzNavigation { get; set; }
        public virtual SchuelerAbitur SchuelerAbitur { get; set; }
        public virtual SchuelerAllgAdr SchuelerAllgAdr { get; set; }
        public virtual SchuelerBkabschluss SchuelerBkabschluss { get; set; }
        public virtual SchuelerFhr SchuelerFhr { get; set; }
        public virtual SchuelerFotos SchuelerFotos { get; set; }
        public virtual ICollection<SchuelerAbgaenge> SchuelerAbgaenge { get; set; }
        public virtual ICollection<SchuelerAbiFaecher> SchuelerAbiFaecher { get; set; }
        public virtual ICollection<SchuelerAnkreuzfloskeln> SchuelerAnkreuzfloskeln { get; set; }
        public virtual ICollection<SchuelerBkfaecher> SchuelerBkfaecher { get; set; }
        public virtual ICollection<SchuelerErzAdr> SchuelerErzAdr { get; set; }
        public virtual ICollection<SchuelerFhrfaecher> SchuelerFhrfaecher { get; set; }
        public virtual ICollection<SchuelerFoerderempfehlungen> SchuelerFoerderempfehlungen { get; set; }
        public virtual ICollection<SchuelerLernabschnittsdaten> SchuelerLernabschnittsdaten { get; set; }
        public virtual ICollection<SchuelerListeInhalt> SchuelerListeInhalt { get; set; }
        public virtual ICollection<SchuelerNuesdaten> SchuelerNuesdaten { get; set; }
        public virtual ICollection<SchuelerSprachenfolge> SchuelerSprachenfolge { get; set; }
        public virtual ICollection<SchuelerTelefone> SchuelerTelefone { get; set; }
        public virtual ICollection<SchuelerVermerke> SchuelerVermerke { get; set; }
    }
}
