using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = "KlassenLehrer")]
    public class Klassenleitung
    {
        [Column(Name = "Klassen_ID")]
        public long KlasseId { get; set; }

        [Column(Name = "Lehrer_ID")]
        public long LehrkraftId { get; set; }

        [Association(ThisKey = nameof(LehrkraftId), OtherKey = nameof(Entity.Lehrkraft.Id))]
        public Lehrkraft Lehrkraft { get; set; }

        [Column(Name = "Reihenfolge")]
        public int Reihenfolge { get; set; }
    }
}
