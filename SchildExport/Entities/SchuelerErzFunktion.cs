using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerErzFunktion
    {
        public int Id { get; set; }
        public int ErzieherId { get; set; }
        public int FunktionId { get; set; }
        public short? Person { get; set; }
        public string Klasse { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual SchuelerErzAdr Erzieher { get; set; }
        public virtual KErzieherFunktion Funktion { get; set; }
    }
}
