using LinqToDB.Mapping;
using SchulIT.SchildExport.Converter;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = "Klassen")]
    public class Klasse
    {
        [Identity, PrimaryKey, Column(Name = "ID")]
        public long Id { get; set; }

        [Column(Name = "Schuljahresabschnitts_ID")]
        public int SchuljahresabschnittId { get; set; }

        [Column(Name = "Bezeichnung")]
        public string Bezeichnung { get; set; }

        [Column(Name = "Klasse")]
        public string Name { get; set; }

        [Column(Name = "Sichtbar")]
        [ValueConverter(ConverterType = typeof(CharBooleanConverter))]
        public bool IstSichtbar { get; set; }

        [Association(ThisKey = nameof(Id), OtherKey = nameof(Entity.Klassenleitung.KlasseId))]
        public IEnumerable<Klassenleitung> Klassenleitung { get; set; }
    }
}
