using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class SchuelerAllgAdr
    {
        public int Id { get; set; }
        public int SchuelerId { get; set; }
        public int AdresseId { get; set; }
        public int? VertragsartId { get; set; }
        public DateTime? Vertragsbeginn { get; set; }
        public DateTime? Vertragsende { get; set; }
        public string Ausbilder { get; set; }
        public string AllgAdrAnschreiben { get; set; }
        public string Praktikum { get; set; }
        public int? Sortierung { get; set; }
        public int? AnsprechpartnerId { get; set; }
        public int? BetreuungslehrerId { get; set; }
        public int? SchulnrEigner { get; set; }

        public virtual KAllgAdresse Adresse { get; set; }
        public virtual AllgAdrAnsprechpartner Ansprechpartner { get; set; }
        public virtual Schueler Schueler { get; set; }
        public virtual KBeschaeftigungsArt Vertragsart { get; set; }
    }
}
