using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = "LehrerLehramtLehrbef")]
    public class Lehrbefaehigung
    {
        [Column(Name = "Lehrer_ID")]
        public long LehrkraftId { get; set; }

        [Column(Name = "LehrbefKrz")]
        public string FachKuerzel { get; set; }
    }
}
