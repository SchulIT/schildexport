using LinqToDB;
using LinqToDB.Data;
using SchulIT.SchildExport.Entities;

namespace SchulIT.SchildExport.Data
{
    class SchildNRWConnection : DataConnection
    {
        public SchildNRWConnection() : base("default") { }

        public ITable<EigeneSchule> EigeneSchule => GetTable<EigeneSchule>();

        public ITable<EigeneSchuleFaecher> EigeneSchuleFaecher => GetTable<EigeneSchuleFaecher>();

        public ITable<KLehrer> KLehrer => GetTable<KLehrer>();

        public ITable<LehrerAbschnittsdaten> LehrerAbschnittsdaten => GetTable<LehrerAbschnittsdaten>();

        public ITable<LehrerLehramtLehrbef> LehrerLehramtLehrbef => GetTable<LehrerLehramtLehrbef>();

        public ITable<Versetzung> Versetzung => GetTable<Versetzung>();

        public ITable<Schueler> Schueler => GetTable<Schueler>();

        public ITable<SchuelerLeistungsdaten> SchuelerLeistungsdaten => GetTable<SchuelerLeistungsdaten>();

        public ITable<SchuelerLernabschnittsdaten> SchuelerLernabschnittsdaten => GetTable<SchuelerLernabschnittsdaten>();

        public ITable<Kurs> Kurse => GetTable<Kurs>();

        public ITable<KursLehrer> KursLehrer => GetTable<KursLehrer>();

        public ITable<KDatenschutz> KDatenschutz => GetTable<KDatenschutz>();

        public ITable<SchuelerDatenschutz> SchuelerDatenschutz => GetTable<SchuelerDatenschutz>();
    }
}
