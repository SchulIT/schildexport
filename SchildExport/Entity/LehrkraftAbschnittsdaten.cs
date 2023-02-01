using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = "LehrerAbschnittsdaten")]
    public class LehrkraftAbschnittsdaten
    {
        [Identity, PrimaryKey, Column(Name = "ID")]
        public long Id { get; set; }

        [Column(Name = "Lehrer_ID")]
        public long LehrkraftId { get; set; }

        [Column(Name = "Schuljahresabschnitts_ID")]
        public long SchuljahresabschnittId { get; set; }
    }
}
