using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = "SchuelerLernplattform")]
    public class KindLernplattform
    {
        [PrimaryKey, Column(Name = "SchuelerID")]
        public long KindId { get; set; }

        [PrimaryKey, Column(Name = "LernplattformID")]
        public long LernplattformId { get; set; }

        [Association(ThisKey = nameof(LernplattformId), OtherKey = nameof(Entity.Lernplattform.Id))]
        public Lernplattform Lernplattform { get; set; }

        [Column(Name = "CredentialID")]
        public long ZugangsdatenId { get; set; }

        [Association(ThisKey = nameof(ZugangsdatenId), OtherKey = nameof(LernplattformZugangsdaten.Id), CanBeNull = true)]
        public LernplattformZugangsdaten Zugangsdaten { get; set; }

        [Column(Name = "EinwilligungAbgefragt")]
        public bool IstEinwilligungAbgefragt { get; set; }

        [Column(Name = "EinwilligungNutzung")]
        public bool IstNutzungEingewilligt { get; set; }

        [Column(Name = "EinwilligungAudiokonferenz")]
        public bool IstAudiokonferenzEingewilligt { get; set; }

        [Column(Name = "EinwilligungVideokonferenz")]
        public bool IstVideokonferenzEingewilligt { get; set; }
    }
}
