using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class AllgAdrAnsprechpartner
    {
        public AllgAdrAnsprechpartner()
        {
            SchuelerAllgAdr = new HashSet<SchuelerAllgAdr>();
        }

        public int Id { get; set; }
        public int? AdresseId { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Anrede { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Abteilung { get; set; }
        public int? SchulnrEigner { get; set; }
        public string Titel { get; set; }
        public string GuId { get; set; }

        public virtual KAllgAdresse Adresse { get; set; }
        public virtual ICollection<SchuelerAllgAdr> SchuelerAllgAdr { get; set; }
    }
}
