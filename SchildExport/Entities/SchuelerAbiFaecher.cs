using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerAbiFaecher
    {
        public int Id { get; set; }
        public int SchuelerId { get; set; }
        public int FachId { get; set; }
        public string FachKrz { get; set; }
        public string KursartAllg { get; set; }
        public string AbiFach { get; set; }
        public string P121 { get; set; }
        public int? H121 { get; set; }
        public string R121 { get; set; }
        public string S121 { get; set; }
        public string P122 { get; set; }
        public int? H122 { get; set; }
        public string R122 { get; set; }
        public string S122 { get; set; }
        public string P131 { get; set; }
        public int? H131 { get; set; }
        public string R131 { get; set; }
        public string S131 { get; set; }
        public string P132 { get; set; }
        public int? H132 { get; set; }
        public string R132 { get; set; }
        public string S132 { get; set; }
        public short? Zulassung { get; set; }
        public double? Durchschnitt { get; set; }
        public short? AbiPruefErgebnis { get; set; }
        public short? Zwischenstand { get; set; }
        public string MdlPflichtPruefung { get; set; }
        public string MdlFreiwPruefung { get; set; }
        public short? MdlPruefErgebnis { get; set; }
        public short? MdlPruefFolge { get; set; }
        public short? AbiErgebnis { get; set; }
        public string MdlBestPruefung { get; set; }
        public int? W121 { get; set; }
        public int? W122 { get; set; }
        public int? W131 { get; set; }
        public int? W132 { get; set; }
        public string PFa { get; set; }
        public string Gekoppelt { get; set; }
        public int? KursId { get; set; }
        public int? Fsortierung { get; set; }
        public int? SchulnrEigner { get; set; }
        public string Fachlehrer { get; set; }
        public string P111 { get; set; }
        public string P112 { get; set; }
        public string S111 { get; set; }
        public string S112 { get; set; }
        public string RFa { get; set; }

        public virtual EigeneSchuleFaecher Fach { get; set; }
        public virtual Schueler Schueler { get; set; }
    }
}
