using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerTelefone
    {
        public int Id { get; set; }
        public int SchuelerId { get; set; }
        public int? TelefonArtId { get; set; }
        public string Telefonnummer { get; set; }
        public string Bemerkung { get; set; }
        public int? Sortierung { get; set; }
        public int? SchulnrEigner { get; set; }
        public string Gesperrt { get; set; }

        public virtual Schueler Schueler { get; set; }
        public virtual KTelefonArt TelefonArt { get; set; }
    }
}
