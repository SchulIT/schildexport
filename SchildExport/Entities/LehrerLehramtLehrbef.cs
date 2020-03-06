using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entities
{
    [Table(Name = "LehrerLehramtLehrbef")]
    class LehrerLehramtLehrbef
    {
        [Column(Name = "Lehrer_ID")]
        public int LehrerId { get; set; }

        [Column(Name = "LehrbefKrz")]
        public string LehrbefKrz { get; set; }
    }
}
