using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerErzAdr
    {
        public SchuelerErzAdr()
        {
            SchuelerErzFunktion = new HashSet<SchuelerErzFunktion>();
        }

        public int Id { get; set; }
        public int SchuelerId { get; set; }
        public int? ErzieherArtId { get; set; }
        public string Anrede1 { get; set; }
        public string Titel1 { get; set; }
        public string Name1 { get; set; }
        public string Vorname1 { get; set; }
        public string Anrede2 { get; set; }
        public string Titel2 { get; set; }
        public string Name2 { get; set; }
        public string Vorname2 { get; set; }
        public string ErzStrasse { get; set; }
        public string ErzPlz { get; set; }
        public int? ErzOrtsteilId { get; set; }
        public string ErzAnschreiben { get; set; }
        public string ErzBemerkung { get; set; }
        public int? Sortierung { get; set; }
        public string ErzEmail { get; set; }
        public string ErzAdrZusatz { get; set; }
        public int? SchulnrEigner { get; set; }
        public string Erz1StaatKrz { get; set; }
        public string Erz2StaatKrz { get; set; }
        public string ErzEmail2 { get; set; }
        public string Erz1ZusatzNachname { get; set; }
        public string Erz2ZusatzNachname { get; set; }
        public string Bemerkungen { get; set; }

        public virtual KOrtsteil ErzOrtsteil { get; set; }
        public virtual KOrt ErzPlzNavigation { get; set; }
        public virtual KErzieherArt ErzieherArt { get; set; }
        public virtual Schueler Schueler { get; set; }
        public virtual ICollection<SchuelerErzFunktion> SchuelerErzFunktion { get; set; }
    }
}
