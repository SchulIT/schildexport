using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = "EigeneSchule")]
    public class EigeneSchule
    {
        [Identity, PrimaryKey, Column(Name = "ID")]
        public long Id { get; set; }

        [Column(Name = "SchulNr")]
        public string SchulNr { get; set; }

        [Column(Name = "Bezeichnung1")]
        public string Bezeichnung1 { get; set; }

        [Column(Name = "Bezeichnung2")]
        public string Bezeichnung2 { get; set; }

        [Column(Name = "Bezeichnung3")]
        public string Bezeichnung3 { get; set; }

        [Column(Name = "Schuljahresabschnitts_ID")]
        public int SchuljahresabschnittId { get; set; }

        [Association(ThisKey = nameof(SchuljahresabschnittId), OtherKey = nameof(Schuljahresabschnitt.Id))]
        public Schuljahresabschnitt AktuellerAbschnitt { get; set; }
    }
}
