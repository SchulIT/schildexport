using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entities
{
    [Table(Name="EigeneSchule")]
    class EigeneSchule
    {
        [Identity, PrimaryKey, Column(Name = "ID")]
        public int Id { get; set; }

        [Column(Name = "SchulNr")]
        public string SchulNr { get; set; }

        [Column(Name = "Bezeichnung1")]
        public string Bezeichnung1 { get; set; }

        [Column(Name = "Bezeichnung2")]
        public string Bezeichnung2 { get; set; }

        [Column(Name = "Bezeichnung3")]
        public string Bezeichnung3 { get; set; }

        [Column(Name = "Schuljahr")]
        public short? Schuljahr { get; set; }

        [Column(Name = "SchuljahrAbschnitt")]
        public short? SchuljahrAbschnitt { get; set; }
    }
}
