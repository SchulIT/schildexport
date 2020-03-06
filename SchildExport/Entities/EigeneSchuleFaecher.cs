using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entities
{
    [Table(Name = "EigeneSchule_Faecher")]
    class EigeneSchuleFaecher
    {
        [Column(Name = "ID"), PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "FachKrz")]
        public string FachKrz { get; set; }

        [Column(Name = "Bezeichnung")]
        public string Bezeichnung { get; set; }

        [Column(Name = "Sichtbar")]
        public char? Sichtbar { get; set; }
    }
}
