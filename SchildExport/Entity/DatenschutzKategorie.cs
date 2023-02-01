using LinqToDB.Mapping;
using SchulIT.SchildExport.Converter;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = "K_Datenschutz")]
    public class DatenschutzKategorie
    {
        [Identity, PrimaryKey, Column(Name = "ID")]
        public long Id { get; set; }

        [Column(Name = "Bezeichnung")]
        public string Bezeichnung { get; set; }

        [Column(Name = "Beschreibung")]
        public string Beschreibung { get; set; }

        [Column(Name = "Sichtbar")]
        [ValueConverter(ConverterType = typeof(CharBooleanConverter))]
        public bool IstSichtbar { get; set; }

        [Column(Name = "PersonArt")]
        public DatenschutzZielgruppe Zielgruppe { get; set; }
    }
}
