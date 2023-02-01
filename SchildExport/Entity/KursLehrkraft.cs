using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = "KursLehrer")]
    public class KursLehrkraft
    {
        [Column(Name = "Kurs_ID")]
        public long KursId { get; set; }

        [Column(Name = "Lehrer_ID")]
        public long LehrkraftId { get; set; }

        [Association(ThisKey = nameof(LehrkraftId), OtherKey = nameof(Entity.Lehrkraft.Id))]
        public Lehrkraft Lehrkraft { get; set; }
    }
}
