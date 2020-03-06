using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entities
{
    [Table(Name = "SchuelerDatenschutz")]
    class SchuelerDatenschutz
    {
        [Column(Name = "Schueler_ID"), PrimaryKey]
        public int SchuelerId { get; set; }

        [Column(Name = "Datenschutz_ID"), PrimaryKey]
        public int DatenschutzId { get; set; }

        [Column(Name = "Status")]
        public char? Status { get; set; }
    }
}
