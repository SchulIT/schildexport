using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerAbitur
    {
        public int Id { get; set; }
        public int SchuelerId { get; set; }
        public string Zugelassen { get; set; }
        public short? SummeGk { get; set; }
        public short? SummeLk { get; set; }
        public short? SummenOk { get; set; }
        public string PruefungBestanden { get; set; }
        public string Note { get; set; }
        public short? GesamtPunktzahl { get; set; }
        public short? Notensprung { get; set; }
        public short? FehlendePunktzahl { get; set; }
        public short? AnzRelLk { get; set; }
        public short? AnzRelGk { get; set; }
        public short? AnzRelOk { get; set; }
        public short? AnzDefLk { get; set; }
        public short? AnzDefGk { get; set; }
        public string BesondereLernleistung { get; set; }
        public string Latinum { get; set; }
        public string KlLatinum { get; set; }
        public string Graecum { get; set; }
        public string Hebraicum { get; set; }
        public string FranzBilingual { get; set; }
        public int? Jahr { get; set; }
        public int? Abschnitt { get; set; }
        public int? FehlStd { get; set; }
        public int? UFehlStd { get; set; }
        public int? SchulnrEigner { get; set; }
        public string BllArt { get; set; }
        public int? BllPunkte { get; set; }
        public string Fs2SekIManuell { get; set; }
        public int? PunktsummeIi { get; set; }
        public int? DefiziteIi { get; set; }
        public int? LkDefiziteIi { get; set; }
        public string ThemaBll { get; set; }
        public string ThemaPjk { get; set; }
        public int? PunktsummeI { get; set; }
        public int? DefiziteI { get; set; }
        public int? LkDefiziteI { get; set; }
        public int? KurseI { get; set; }
        public int? FaPunkte { get; set; }
        public string FaFach { get; set; }
        public int? AnzahlKurse0 { get; set; }
        public double? DurchschnittI { get; set; }

        public virtual Schueler Schueler { get; set; }
    }
}
