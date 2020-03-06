using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entities
{
    [Table(Name = "KursLehrer")]
    class KursLehrer
    {
        [Column(Name = "Kurs_ID"), PrimaryKey]
        public int KursId { get; set; }

        [Column(Name = "Lehrer_ID"), PrimaryKey]
        public int LehrerId { get; set; }

        [Column(Name = "Anteil")]
        public double Anteil { get; set; }
    }
}
