using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entities
{
    [Table(Name = "Versetzung")]
    class Versetzung
    {
        [Identity, PrimaryKey, Column(Name = "ID")]
        public int Id { get; set; }

        [Column(Name = "ASDKlasse")]
        public string ASDKlasse { get; set; }

        [Column(Name = "Klasse")]
        public string Klasse { get; set; }

        [Column(Name = "KlassenlehrerKrz")]
        public string KlassenlehrerKrz { get; set; }

        [Column(Name = "StvKlassenlehrerKrz")]
        public string StvKlassenlehrerKrz { get; set; }

        [Column(Name = "Sichtbar")]
        public char? Sichtbar { get; set; }
    }
}
