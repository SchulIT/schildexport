using LinqToDB.Mapping;
using SchulIT.SchildExport.Converter;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = "LehrerDatenschutz")]
    public class LehrkraftDatenschutz
    {
        [Column(Name = "LehrerID")]
        public long LehrkraftId { get; set; }

        [Column(Name = "DatenschutzID")]
        public long KategorieId { get; set; }

        [Association(ThisKey = nameof(KategorieId), OtherKey = nameof(DatenschutzKategorie.Id))]
        public DatenschutzKategorie Kategorie { get; set; }

        [Column(Name = "Status")]
        [ValueConverter(ConverterType = typeof(IntBooleanConverter))]
        public bool IstZugestimmt { get; set; }


        [Column(Name = "Abgefragt")]
        public bool IstAbgefragt { get; set; }
    }
}
