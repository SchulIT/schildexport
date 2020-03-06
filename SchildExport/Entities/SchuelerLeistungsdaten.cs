using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entities
{
    [Table(Name = "SchuelerLeistungsdaten")]
    class SchuelerLeistungsdaten
    {
        [Column(Name = "ID"), PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "Abschnitt_ID"), NotNull]
        public int AbschnittId { get; set; }

        [Column(Name = "Fach_ID"), NotNull]
        public int FachId { get; set; }

        [Column(Name = "FachLehrer")]
        public string FachLeher { get; set; }

        [Column(Name = "Zusatzkraft")]
        public string Zusatzkraft { get; set; }

        [Column(Name = "Kursart")]
        public string Kursart { get; set; }

        [Column(Name = "Kurs_ID")]
        public int? KursId { get; set; }
    }
}
