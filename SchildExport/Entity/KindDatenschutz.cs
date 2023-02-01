using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = "SchuelerDatenschutz")]
    public class KindDatenschutz
    {
        [Column(Name = "Schueler_ID")]
        public long KindId { get; set; }

        [Column(Name = "Datenschutz_ID")]
        public long KategorieId { get; set; }

        [Association(ThisKey = nameof(KategorieId), OtherKey = nameof(DatenschutzKategorie.Id))]
        public DatenschutzKategorie Kategorie { get; set; }

        [Column(Name = "Status")]
        public DatenschutzZustimmung Status { get; set; }

        [Column(Name = "Abgefragt")]
        public bool IstAbgefragt { get; set; }
    }
}
