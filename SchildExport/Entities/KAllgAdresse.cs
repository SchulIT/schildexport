using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class KAllgAdresse
    {
        public KAllgAdresse()
        {
            AllgAdrAnsprechpartner = new HashSet<AllgAdrAnsprechpartner>();
            SchuelerAllgAdr = new HashSet<SchuelerAllgAdr>();
        }

        public int Id { get; set; }
        public string AllgAdrAdressArt { get; set; }
        public string AllgAdrName1 { get; set; }
        public string AllgAdrName2 { get; set; }
        public string AllgAdrStrasse { get; set; }
        public string AllgAdrPlz { get; set; }
        public string AllgAdrTelefon1 { get; set; }
        public string AllgAdrTelefon2 { get; set; }
        public string AllgAdrFax { get; set; }
        public string AllgAdrEmail { get; set; }
        public string AllgAdrBemerkungen { get; set; }
        public short? Sortierung { get; set; }
        public string AllgAdrAusbildungsBetrieb { get; set; }
        public string AllgAdrBietetPraktika { get; set; }
        public string AllgAdrBranche { get; set; }
        public string AllgAdrZusatz1 { get; set; }
        public string AllgAdrZusatz2 { get; set; }
        public string Sichtbar { get; set; }
        public string Aenderbar { get; set; }
        public int? SchulnrEigner { get; set; }
        public string Massnahmentraeger { get; set; }
        public string BelehrungIsg { get; set; }
        public string GuId { get; set; }
        public string ErwFuehrungszeugnis { get; set; }
        public string ExtId { get; set; }

        public virtual KAdressart AllgAdrAdressArtNavigation { get; set; }
        public virtual ICollection<AllgAdrAnsprechpartner> AllgAdrAnsprechpartner { get; set; }
        public virtual ICollection<SchuelerAllgAdr> SchuelerAllgAdr { get; set; }
    }
}
