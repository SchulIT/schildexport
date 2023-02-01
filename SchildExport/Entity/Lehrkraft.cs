using LinqToDB.Mapping;
using SchulIT.SchildExport.Converter;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = "K_Lehrer")]
    public class Lehrkraft
    {
        [Identity, PrimaryKey, Column(Name = "ID")]
        public long Id { get; set; }

        [Column(Name = "Kuerzel")]
        public string Kuerzel { get; set; }

        [Column(Name = "Nachname"), NotNull]
        public string Nachname { get; set; }

        [Column(Name = "Vorname")]
        public string Vorname { get; set; }

        [Column(Name = "Titel")]
        public string Titel { get; set; }

        [Column(Name = "Amtsbezeichnung")]
        public string Amtsbezeichnung { get; set; }

        [Column(Name = "Sichtbar")]
        [ValueConverter(ConverterType = typeof(CharBooleanConverter))]
        public bool IstSichtbar { get; set; }

        [Column(Name = "Geschlecht")]
        public Geschlecht Geschlecht { get; set; }

        [Column(Name = "EMailDienstlich")]
        public string EmailDienstlich { get; set; }

        [Association(ThisKey = nameof(Id), OtherKey = nameof(Lehrbefaehigung.LehrkraftId))]
        public IEnumerable<Lehrbefaehigung> Lehrbefaehigungen { get; set; }

        [Association(ThisKey = nameof(Id), OtherKey = nameof(LehrkraftAbschnittsdaten.LehrkraftId))]
        public IEnumerable<LehrkraftAbschnittsdaten> Abschnittsdaten { get; set; }
    }
}
