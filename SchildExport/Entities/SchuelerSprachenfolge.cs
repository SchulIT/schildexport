using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerSprachenfolge
    {
        public int Id { get; set; }
        public int SchuelerId { get; set; }
        public int FachId { get; set; }
        public short? JahrgangVon { get; set; }
        public short? JahrgangBis { get; set; }
        public string Reihenfolge { get; set; }
        public short? AbschnittVon { get; set; }
        public short? AbschnittBis { get; set; }
        public int? SchulnrEigner { get; set; }
        public string Referenzniveau { get; set; }

        public virtual EigeneSchuleFaecher Fach { get; set; }
        public virtual Schueler Schueler { get; set; }
    }
}
