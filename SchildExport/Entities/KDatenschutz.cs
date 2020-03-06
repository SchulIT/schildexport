using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entities
{
    [Table(Name = "K_Datenschutz")]
    class KDatenschutz
    {
        [Column(Name = "ID"), PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "Bezeichnung")]
        public string Bezeichnung { get; set; }

        [Column(Name = "Sichtbar")]
        public char? Sichtbar { get; set; }

        [Column(Name = "Beschreibung")]
        public string Beschreibung { get; set; }
    }
}
