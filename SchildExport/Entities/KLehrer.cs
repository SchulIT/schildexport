using LinqToDB.Mapping;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    [Table(Name = "K_Lehrer")]
    class KLehrer
    {
        [PrimaryKey, Identity, Column(Name = "ID")]
        public int Id { get; set; }

        [Column(Name = "Kuerzel")]
        public string Kuerzel { get; set; }

        [Column(Name = "Nachname"), NotNull]
        public string Nachname { get; set; }

        [Column(Name = "Vorname")]
        public string Vorname { get; set; }

        [Column(Name = "Anrede")]
        public string Anrede { get; set; }

        [Column(Name = "Titel")]
        public string Titel { get; set; }

        [Column(Name = "Sichtbar")]
        public char? Sichtbar { get; set; }

        [Column(Name = "Geschlecht")]
        public Geschlecht Geschlecht { get; set; }

        [Column(Name = "EMailDienstlich")]
        public string EmailDienstlich { get; set; }

        public IEnumerable<LehrerAbschnittsdaten> Abschnittsdaten { get; set; }

        public IEnumerable<LehrerLehramtLehrbef> Lehrbefaehigungen { get; set; }
    }
}
