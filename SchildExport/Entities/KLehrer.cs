using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class KLehrer
    {
        public KLehrer()
        {
            EigeneSchuleAbteilungen = new HashSet<EigeneSchuleAbteilungen>();
            KursLehrer = new HashSet<KursLehrer>();
            LehrerAbschnittsdaten = new HashSet<LehrerAbschnittsdaten>();
            LehrerImei = new HashSet<LehrerImei>();
            Versetzung = new HashSet<Versetzung>();
        }

        public int Id { get; set; }
        public string Kuerzel { get; set; }
        public string Lidkrz { get; set; }
        public string Nachname { get; set; }
        public string Vorname { get; set; }
        public string Anrede { get; set; }
        public string Titel { get; set; }
        public short? Sortierung { get; set; }
        public string Sichtbar { get; set; }
        public string Aenderbar { get; set; }
        public DateTime? Geburtsdatum { get; set; }
        public string Geschlecht { get; set; }
        public string SerNr { get; set; }
        public string StaatKrz { get; set; }
        public string Rechtsverhaeltnis { get; set; }
        public string Beschaeftigungsart { get; set; }
        public string Einsatzstatus { get; set; }
        public double? PflichtstdSoll { get; set; }
        public double? UnterrichtsStd { get; set; }
        public string Strasse { get; set; }
        public string Plz { get; set; }
        public string Tel { get; set; }
        public string Handy { get; set; }
        public string Email { get; set; }
        public string Statistik { get; set; }
        public string StammschulNr { get; set; }
        public DateTime? DatumZugang { get; set; }
        public DateTime? DatumAbgang { get; set; }
        public string GrundZugang { get; set; }
        public string GrundAbgang { get; set; }
        public string SchulFunktion { get; set; }
        public double? MehrleistungStd { get; set; }
        public double? EntlastungStd { get; set; }
        public double? AnrechnungStd { get; set; }
        public double? RestStd { get; set; }
        public string Amtsbezeichnung { get; set; }
        public string IdentNr1 { get; set; }
        public int? SchulnrEigner { get; set; }
        public string GuId { get; set; }
        public string Faecher { get; set; }
        public string FuerExport { get; set; }
        public string PersonTyp { get; set; }
        public string Lpassword { get; set; }
        public string Pwaktuell { get; set; }
        public string SchIldwebFl { get; set; }
        public string SchIldwebKl { get; set; }
        public string SchIldwebConfig { get; set; }
        public string EmailDienstlich { get; set; }
        public string KennwortTools { get; set; }
        public string Antwort1 { get; set; }
        public string Antwort2 { get; set; }
        public string Panr { get; set; }
        public string Lbvnr { get; set; }
        public string Vschluessel { get; set; }
        public string KennwortToolsAktuell { get; set; }

        public virtual ICollection<EigeneSchuleAbteilungen> EigeneSchuleAbteilungen { get; set; }
        public virtual ICollection<KursLehrer> KursLehrer { get; set; }
        public virtual ICollection<LehrerAbschnittsdaten> LehrerAbschnittsdaten { get; set; }
        public virtual ICollection<LehrerImei> LehrerImei { get; set; }
        public virtual ICollection<Versetzung> Versetzung { get; set; }
    }
}
