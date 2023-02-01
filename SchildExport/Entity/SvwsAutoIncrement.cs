using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = "SVWS_DB_AutoInkremente")]
    public class SvwsAutoIncrement
    {
        [PrimaryKey, Column(Name = "NameTabelle")]
        public string Tabelle { get; set; }

        [Column(Name = "MaxID")]
        public long MaxId { get; set; }
    }
}
