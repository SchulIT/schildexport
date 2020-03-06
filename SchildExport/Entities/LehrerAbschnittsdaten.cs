using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entities
{
    [Table(Name = "LehrerAbschnittsdaten")]
    class LehrerAbschnittsdaten
    {
        [Column(Name = "Lehrer_ID"), NotNull, PrimaryKey]
        public int LehrerId { get; set; }

        [Column(Name = "Jahr"), PrimaryKey]
        public short Jahr { get; set; }

        [Column(Name = "Jahr"), PrimaryKey]
        public short Abschnitt { get; set; }

        [Column(Name = "Rechtsverhaeltnis")]
        public string Rechtsverhaeltnis { get; set; }
    }
}
