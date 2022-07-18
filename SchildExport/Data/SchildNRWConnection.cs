using LinqToDB;
using LinqToDB.Data;
using SchulIT.SchildExport.Entities;

namespace SchulIT.SchildExport.Data
{
    class SchildNRWConnection : DataConnection
    {
        public SchildNRWConnection() : base("default") { }

        public ITable<EigeneSchule> EigeneSchule => this.GetTable<EigeneSchule>();

        public ITable<EigeneSchuleFaecher> EigeneSchuleFaecher => this.GetTable<EigeneSchuleFaecher>();

        public ITable<KLehrer> KLehrer => this.GetTable<KLehrer>();

        public ITable<LehrerAbschnittsdaten> LehrerAbschnittsdaten => this.GetTable<LehrerAbschnittsdaten>();

        public ITable<LehrerLehramtLehrbef> LehrerLehramtLehrbef => this.GetTable<LehrerLehramtLehrbef>();

        public ITable<Versetzung> Versetzung => this.GetTable<Versetzung>();

        public ITable<Schueler> Schueler => this.GetTable<Schueler>();

        public ITable<SchuelerLeistungsdaten> SchuelerLeistungsdaten => this.GetTable<SchuelerLeistungsdaten>();

        public ITable<SchuelerLernabschnittsdaten> SchuelerLernabschnittsdaten => this.GetTable<SchuelerLernabschnittsdaten>();

        public ITable<Kurs> Kurse => this.GetTable<Kurs>();

        public ITable<KursLehrer> KursLehrer => this.GetTable<KursLehrer>();

        public ITable<KDatenschutz> KDatenschutz => this.GetTable<KDatenschutz>();

        public ITable<SchuelerDatenschutz> SchuelerDatenschutz => this.GetTable<SchuelerDatenschutz>();
    }
}
