using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = "Schuljahresabschnitte")]
    public class Schuljahresabschnitt
    {
        [Identity, PrimaryKey, Column(Name = "ID")]
        public long Id { get; set; }

        [Column(Name = "Jahr")]
        public long Jahr { get; set; }

        [Column(Name = "Abschnitt")]
        public long Abschnitt { get; set; }
    }
}
