using LinqToDB.Mapping;
using System;

namespace SchulIT.SchildExport.Entities
{
    [Table(Name = "Schueler")]
    class Schueler
    {
        [Column(Name = "ID"), PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "Status")]
        public SchuelerStatus Status { get; set; }

        [Column(Name = "Klasse")]
        public string Klasse { get; set; }

        [Column(Name = "Name")]
        public string Name { get; set; }

        [Column(Name = "Vorname")]
        public string Vorname { get; set; }

        [Column(Name = "Geburtsdatum")]
        public DateTime? Geburtsdatum { get; set; }

        [Column(Name = "Volljaehrig")]
        public char? Volljaehrig { get; set; }

        [Column(Name = "Geschlecht")]
        public Geschlecht Geschlecht { get; set; }

        [Column(Name = "SchulEmail")]
        public string SchulEmail { get; set; }

        [Column(Name = "Entlassdatum")]
        public DateTime? Entlassdatum { get; set; }
    }
}
