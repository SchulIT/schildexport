using LinqToDB;
using LinqToDB.Data;
using SchulIT.SchildExport.Entity;

namespace SchulIT.SchildExport.Data
{
    class SvwsConnection : DataConnection
    {
        public SvwsConnection() : base("svws") { }

        public ITable<EigeneSchule> EigeneSchule => this.GetTable<EigeneSchule>();

        public ITable<Schuljahresabschnitt> Schuljahresabschnitte => this.GetTable<Schuljahresabschnitt>();

        public ITable<Lehrkraft> Lehrkraefte => this.GetTable<Lehrkraft>();

        public ITable<Klasse> Klassen => this.GetTable<Klasse>();

        public ITable<Fach> Faecher => this.GetTable<Fach>();

        public ITable<Kind> Kinder => this.GetTable<Kind>();

        public ITable<Kurs> Kurse => this.GetTable<Kurs>();

        public ITable<KindLeistungsdaten> Leistungsdaten => this.GetTable<KindLeistungsdaten>();

        public ITable<DatenschutzKategorie> DatenschutzKategorien => this.GetTable<DatenschutzKategorie>();

        public ITable<Lernplattform> Lernplattformen => this.GetTable<Lernplattform>();

        public ITable<KindLernplattform> KindLernplattformZustimmungen => this.GetTable<KindLernplattform>();

        public ITable<LernplattformZugangsdaten> LernplattformZugangsdaten => this.GetTable<LernplattformZugangsdaten>();
        
        public ITable<SvwsAutoIncrement> SvwsAutoIncrements => this.GetTable<SvwsAutoIncrement>();

    }
}
