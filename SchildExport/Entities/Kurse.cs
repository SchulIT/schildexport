using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class Kurse
    {
        public Kurse()
        {
            KursLehrer = new HashSet<KursLehrer>();
            SchuelerLeistungsdaten = new HashSet<SchuelerLeistungsdaten>();
        }

        public int Id { get; set; }
        public short Jahr { get; set; }
        public short Abschnitt { get; set; }
        public string KurzBez { get; set; }
        public int? JahrgangId { get; set; }
        public string Asdjahrgang { get; set; }
        public int FachId { get; set; }
        public string KursartAllg { get; set; }
        public short? Wochenstd { get; set; }
        public string LehrerKrz { get; set; }
        public short? Sortierung { get; set; }
        public string Sichtbar { get; set; }
        public string Schienen { get; set; }
        public string Fortschreibungsart { get; set; }
        public double? WochenstdKl { get; set; }
        public int? Schulnr { get; set; }
        public string EpochU { get; set; }
        public int? SchulnrEigner { get; set; }
        public string Zeugnisbez { get; set; }
        public string Jahrgaenge { get; set; }

        public virtual ICollection<KursLehrer> KursLehrer { get; set; }
        public virtual ICollection<SchuelerLeistungsdaten> SchuelerLeistungsdaten { get; set; }
    }
}
