using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerBkfaecher
    {
        public int Id { get; set; }
        public int SchuelerId { get; set; }
        public int FachId { get; set; }
        public string FachKrz { get; set; }
        public string FachSchriftlich { get; set; }
        public string FachSchriftlichBa { get; set; }
        public string Vornote { get; set; }
        public string NoteSchriftlich { get; set; }
        public string MdlPruefung { get; set; }
        public string MdlPruefungFw { get; set; }
        public string NoteMuendlich { get; set; }
        public string NoteAbschluss { get; set; }
        public string NotePrfGesamt { get; set; }
        public int? Fsortierung { get; set; }
        public int? SchulnrEigner { get; set; }
        public string Fachlehrer { get; set; }
        public string NoteAbschlussBa { get; set; }

        public virtual EigeneSchuleFaecher Fach { get; set; }
        public virtual Schueler Schueler { get; set; }
    }
}
