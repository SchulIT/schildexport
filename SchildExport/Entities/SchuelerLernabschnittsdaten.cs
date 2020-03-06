using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entities
{
    [Table(Name = "SchuelerLernabschnittsdaten")]
    class SchuelerLernabschnittsdaten
    {
        [Column(Name = "ID"), PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "Schueler_ID")]
        public int SchuelerId { get; set; }

        [Column(Name = "Jahr")]
        public short Jahr { get; set; }

        [Column(Name = "Abschnitt")]
        public short Abschnitt { get; set; }

        [Column(Name = "Klasse")]
        public string Klasse { get; set; }
    }
}
