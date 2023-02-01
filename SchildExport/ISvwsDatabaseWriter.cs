using SchulIT.SchildExport.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchulIT.SchildExport
{
    internal interface ISvwsDatabaseWriter : IDatabaseConfigurator
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
    }
}
