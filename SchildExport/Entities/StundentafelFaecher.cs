using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class StundentafelFaecher
    {
        public int Id { get; set; }
        public int StundentafelId { get; set; }
        public int FachId { get; set; }
        public string KursartAllg { get; set; }
        public short? WochenStd { get; set; }
        public string LehrerKrz { get; set; }
        public string EpochenUnterricht { get; set; }
        public short? Sortierung { get; set; }
        public string Sichtbar { get; set; }
        public int? Gewichtung { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual EigeneSchuleFaecher Fach { get; set; }
        public virtual Stundentafel Stundentafel { get; set; }
    }
}
