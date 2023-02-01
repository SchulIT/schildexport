using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = "Kurs_Schueler")]
    public class KursKind
    {
        [Column(Name = "Kurs_ID")]
        public long KursId { get; set; }

        [Column(Name = "Schueler_ID")]
        public long KindId { get; set; }

        [Association(ThisKey = nameof(KindId), OtherKey = nameof(Entity.Kind.Id))]
        public Kind Kind { get; set; }
    }
}
