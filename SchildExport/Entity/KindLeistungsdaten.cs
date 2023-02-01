using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = "SchuelerLeistungsdaten")]
    public class KindLeistungsdaten
    {
        [Identity, PrimaryKey, Column(Name = "ID")]
        public long Id { get; set; }

        [Column(Name = "Abschnitt_ID")]
        public long KindLernabschnittId { get; set; }

        [Association(ThisKey = nameof(KindLernabschnittId), OtherKey = nameof(KindLernabschnitt.Id))]
        public KindLernabschnitt Lernabschnitt { get; set; }

        [Column(Name = "Fach_ID")]
        public long FachId { get; set; }

        [Association(ThisKey = nameof(FachId), OtherKey = nameof(Entity.Fach.Id))]
        public Fach Fach { get; set; }

        [Column(Name = "FachLehrer_ID")]
        public long LehrkraftId { get; set; }

        [Association(ThisKey = nameof(LehrkraftId), OtherKey = nameof(Entity.Lehrkraft.Id))]
        public Lehrkraft Lehrkraft { get; set; }

        [Column(Name = "Zusatzkraft_ID")]
        public long? ZusaetzlicheLehrkraftId { get; set; }

        [Association(ThisKey = nameof(ZusaetzlicheLehrkraftId), OtherKey = nameof(Entity.Lehrkraft.Id))]
        public Lehrkraft ZusaetzlicheLehrkraft { get; set; }

        [Column(Name = "Kursart")]
        public string Kursart { get; set; }

        [Column(Name = "Kurs_ID")]
        public long? KursId { get; set; }

        [Association(ThisKey = nameof(KursId), OtherKey = nameof(Entity.Kurs.Id), CanBeNull = true)]
        public Kurs Kurs { get; set; }
    }
}
