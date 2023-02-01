using LinqToDB.Mapping;

namespace SchulIT.SchildExport.Entity
{
    [Table(Name = Lernplattform.TableName)]
    public class Lernplattform
    {
        public const string TableName = "Lernplattformen";

        [Identity, PrimaryKey, Column(Name = "ID")]
        public long Id { get; set; }

        [Column(Name = "Bezeichnung")]
        public string Bezeichnung { get; set; }

        [Column(Name = "BenutzernameSuffixLehrer")]
        public string BenutzernameSuffixLehrkraefte { get; set; }

        [Column(Name = "BenutzernameSuffixSchueler")]
        public string BenutzernameSuffixKinder { get; set; }

        [Column(Name = "BenutzernameSuffixErzieher")]
        public string BenutzernameSuffixErzieher { get; set; }
    }
}
