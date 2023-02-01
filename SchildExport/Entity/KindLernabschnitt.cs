using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = "SchuelerLernabschnittsdaten")]
    public class KindLernabschnitt
    {
        [Identity, PrimaryKey, Column(Name = "ID")]
        public long Id { get; set; }

        [Column(Name = "Schueler_ID")]
        public long KindId { get; set; }

        [Association(ThisKey = nameof(KindId), OtherKey = nameof(Entity.Kind.Id))]
        public Kind Kind { get; set; }

        [Column(Name = "Schuljahresabschnitts_ID")]
        public long SchuljahresabschnittId { get; set; }

        [Column(Name = "Klassen_ID")]
        public long KlasseId { get; set; }

        [Association(ThisKey = nameof(KlasseId), OtherKey = nameof(Entity.Klasse.Id))]
        public Klasse Klasse { get; set; }
    }
}
