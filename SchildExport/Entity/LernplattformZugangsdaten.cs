using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = LernplattformZugangsdaten.TableName)]
    public class LernplattformZugangsdaten
    {
        public const string TableName = "CredentialsLernplattformen";

        [Identity, PrimaryKey, Column(Name = "ID")]
        public long Id { get; set; }

        [Column(Name = "LernplattformID")]
        public long LernplattformId { get; set; }

        [Association(ThisKey = nameof(LernplattformId), OtherKey = nameof(Entity.Lernplattform.Id))]
        public Lernplattform Lernplattform { get; set; }

        [Column(Name = "Benutzername")]
        public string Benutzername { get; set; }

        [Column(Name = "BenutzernamePseudonym")]
        public string BenutzernamePseudonym { get; set; }

        [Column(Name = "Initialkennwort")]
        public string InitialKennwort { get; set; }
    }
}
