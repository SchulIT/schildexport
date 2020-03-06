using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entities
{
    [Table(Name = "Kurse")]
    class Kurs
    {
        [Column(Name = "ID"), PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "Jahr")]
        public short Jahr { get; set; }

        [Column(Name = "Abschnitt")]
        public short Abschnitt { get; set; }

        [Column(Name = "KurzBez")]
        public string KurzBez { get; set; }

        [Column(Name = "JahrgangId")]
        public int? JahrgangId { get; set; }

        [Column(Name = "FachId")]
        public int FachId { get; set; }

        [Column(Name = "Sichtbar")]
        public char? Sichtbar { get; set; }
    }
}
