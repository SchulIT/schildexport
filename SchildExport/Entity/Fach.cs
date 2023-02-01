using LinqToDB.Mapping;
using SchulIT.SchildExport.Converter;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = "EigeneSchule_Faecher")]
    public class Fach
    {
        [Identity, PrimaryKey, Column(Name = "ID")]
        public long Id { get; set; }

        [Column(Name = "FachKrz")]
        public string Kuerzel { get; set; }

        [Column(Name = "Bezeichnung")]
        public string Bezeichnung { get; set; }

        [Column(Name = "Sichtbar")]
        [ValueConverter(ConverterType = typeof(CharBooleanConverter))]
        public bool IstSichtbar { get; set; }
    }
}
