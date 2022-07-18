namespace SchulIT.SchildExport
{
    /// <summary>
    /// Art der Datenbank zur Verbindung mit SchILD. 
    /// </summary>
    public enum ConnectionProvider
    {
        /// <summary>
        /// Microsoft Access - WICHTIG: Benötigt das NuGet Paket System.Data.Odbc
        /// </summary>
        Access,

        /// <summary>
        /// SQL Server - Kompatibilität mit 2008 - WICHTIG: Benötigt das NuGet Paket Microsoft.Data.SqlClient
        /// </summary>
        SqlServer,

        /// <summary>
        /// SQL Server 2017 - WICHTIG: Benötigt das NuGet Paket Microsoft.Data.SqlClient
        /// </summary>
        SqlServer2017,

        /// <summary>
        /// MySQL Connector/MariaDB Connector - WICHTIG: Benötigt das NuGet Paket MySqlConnector
        /// </summary>
        MySqlConnector
    }
}
