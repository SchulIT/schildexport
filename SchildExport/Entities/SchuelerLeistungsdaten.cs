using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerLeistungsdaten
    {
        public int Id { get; set; }
        public int AbschnittId { get; set; }
        public int FachId { get; set; }
        public int? Hochrechnung { get; set; }
        public string FachLehrer { get; set; }
        public string Kursart { get; set; }
        public string KursartAllg { get; set; }
        public int? KursId { get; set; }
        public string NotenKrz { get; set; }
        public string Warnung { get; set; }
        public DateTime? Warndatum { get; set; }
        public string AbiFach { get; set; }
        public short? Wochenstunden { get; set; }
        public string AbiZeugnis { get; set; }
        public string Prognose { get; set; }
        public short? Fehlstd { get; set; }
        public short? UFehlstd { get; set; }
        public short? Sortierung { get; set; }
        public string Lernentw { get; set; }
        public string Gekoppelt { get; set; }
        public string VorherAbgeschl { get; set; }
        public string AbschlussJahrgang { get; set; }
        public string HochrechnungStatus { get; set; }
        public int? SchulNr { get; set; }
        public string Zusatzkraft { get; set; }
        public int? WochenstdZusatzkraft { get; set; }
        public string Prf10Fach { get; set; }
        public string AufZeugnis { get; set; }
        public int? Gewichtung { get; set; }
        public int? SchulnrEigner { get; set; }
        public string NoteAbschlussBa { get; set; }

        public virtual SchuelerLernabschnittsdaten Abschnitt { get; set; }
        public virtual EigeneSchuleFaecher Fach { get; set; }
        public virtual Kurse Kurs { get; set; }
    }
}
