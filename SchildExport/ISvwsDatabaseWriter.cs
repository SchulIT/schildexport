using SchulIT.SchildExport.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchulIT.SchildExport
{
    public interface ISvwsDatabaseWriter : IDatabaseConfigurator
    {
        /// <summary>
        /// Fügt eine neue Lernplattform in die Datenbank ein oder aktualisiert sie, falls sie
        /// bereits vorhanden ist (d.h. ID > 0). Nach dem Einfügen wird die neue ID der Lernplattform
        /// entsprechend im übergebenen Objekt gesetzt.
        /// 
        /// Achtung: es wird keine Validierung vorgenommen.
        /// </summary>
        /// <param name="lernplattform"></param>
        /// <returns></returns>
        public Task InsertOrUpdateLernplattformAsync(Lernplattform lernplattform);

        public Task InsertOrUpdateLernplattformZustimmungenBulkAsync(IEnumerable<KindLernplattform> zustimmungen);

        /// <summary>
        /// Aktualisiert die E-Mail-Adresse eines Kindes in der SVWS-Datenbank.
        /// 
        /// Achtung: Es wird nur das Feld SchulEmail aktualisiert, alle anderen Felder bleiben unverändert.
        /// </summary>
        /// <param name="kind"></param>
        /// <returns></returns>
        public Task UpdateKinderBulkAsync(IEnumerable<Kind> kind);

        /// <summary>
        /// Pensioniert alle Zugangsdaten, außer für die angegebenen Kinder. Diese Funktion ist hilfreich, um Benutzernamen
        /// wieder vergeben zu können.
        /// 
        /// Die Methode löscht die Zugangsdaten nicht, sondern stellt ein "RETIRED_" mit dem Datum der Ausführung
        /// vor den Benutzernamen.
        /// 
        /// Falls die Zugangsdaten gelöscht werden sollen, kann die Methode <see cref="DeleteLernplattformCredentials(IEnumerable{Kind})"/>
        /// verwendet werden.
        /// </summary>
        /// <param name="zubehaltendeKinder"></param>
        /// <returns></returns>
        public Task RetireLernplattformCredentials(IEnumerable<Kind> zubehaltendeKinder);

        /// <summary>
        /// Löscht alle Zugangsdaten, außer für die angegebenen Kinder.
        /// </summary>
        /// <param name="zubehaltendeKinder"></param>
        /// <returns></returns>
        public Task DeleteLernplattformCredentials(IEnumerable<Kind> zubehaltendeKinder);
    }
}
