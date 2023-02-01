using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = "Schueler")]
    public class Kind
    {
        [Identity, PrimaryKey, Column(Name = "ID")]
        public long Id { get; set; }

        [Column(Name = "Status")]
        public KindStatus Status { get; set; }

        [Column(Name = "Name")]
        public string Nachname { get; set; }

        [Column(Name = "Vorname")]
        public string Vorname { get; set; }

        [Column(Name = "Geburtsdatum")]
        public DateTime? Geburtsdatum { get; set; }

        [Column(Name = "Geschlecht")]
        public Geschlecht Geschlecht { get; set; }

        [Column(Name = "SchulEmail")]
        public string SchulEmail { get; set; }

        [Association(ThisKey = nameof(Id), OtherKey = nameof(KindLernabschnitt.KindId))]
        public IEnumerable<KindLernabschnitt> Lernabschnitte { get; set; }

        [Association(ThisKey = nameof(Id), OtherKey = nameof(KindDatenschutz.KindId))]
        public IEnumerable<KindDatenschutz> DatenschutzZustimmungen { get; set; }

        [Association(ThisKey = nameof(Id), OtherKey = nameof(KindLernplattform.KindId))]
        public IEnumerable<KindLernplattform> LernplattformZustimmungen { get; set; }
    }
}
