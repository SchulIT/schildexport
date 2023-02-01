namespace SchulIT.SchildExport
{
    public interface IDatabaseConfigurator
    {
        /// <summary>
        /// Konfiguriert den Datenbankzugriff
        /// </summary>
        /// <param name="host">Host zur MariaDB-Datenbank</param>
        /// <param name="port">Port zur MariaDB-Datenbank (3306 ist der Standardport)</param>
        /// <param name="database">Name der Datenbank</param>
        /// <param name="username">Benutzername</param>
        /// <param name="password">Passwort</param>
        /// <param name="enableTrace"></param>
        void Configure(string host, int port, string database, string username, string password, bool enableTrace);
    }
}
