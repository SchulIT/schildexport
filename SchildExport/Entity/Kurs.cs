using LinqToDB.Mapping;
using SchulIT.SchildExport.Converter;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = "Kurse")]
    public class Kurs
    {
        [Identity, PrimaryKey, Column(Name = "ID" )]
        public long Id { get; set; }

        [Column(Name = "Schuljahresabschnitts_ID")]
        public long SchuljahresabschnittId { get; set; }

        [Column(Name = "KurzBez")]
        public string Bezeichnung { get; set; }

        [Column(Name = "Fach_ID")]
        public long FachId { get; set; }

        [Association(ThisKey = nameof(FachId), OtherKey = nameof(Entity.Fach.Id))]
        public Fach Fach { get; set; }

        [Column(Name = "Sichtbar")]
        [ValueConverter(ConverterType = typeof(CharBooleanConverter))]
        public bool IstSichtbar { get; set; }

        [Column(Name = "ZeugnisBez")]
        public string ZeugnisBezeichnung { get; set; }

        [Column(Name = "Jahrgaenge")]
        public string Jahrgaenge { get; set; }

        [Column(Name = "Lehrer_ID")]
        public long LehrkraftId { get; set; }

        [Association(ThisKey = nameof(LehrkraftId), OtherKey = nameof(Entity.Lehrkraft.Id))]
        public Lehrkraft Lehrkraft { get; set; }

        [Association(ThisKey = nameof(Id), OtherKey = nameof(KursLehrkraft.KursId))]
        public IEnumerable<KursLehrkraft> Lehrkraefte { get; set; }

        [Association(ThisKey = nameof(Id), OtherKey = nameof(KursKind.KursId))]
        public IEnumerable<KursKind> Kinder { get; set; }
    }
}
