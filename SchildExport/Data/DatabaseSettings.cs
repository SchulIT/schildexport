using LinqToDB;
using LinqToDB.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Data
{
    public class DatabaseSettings : ILinqToDBSettings
    {
        private readonly string host;
        private readonly int port;
        private readonly string database;
        private readonly string username;
        private readonly string password;

        public DatabaseSettings(string host, int port, string database, string username, string password)
        {
            this.host = host;
            this.port = port;
            this.database = database;
            this.username = username;
            this.password = password;
        }

        public IEnumerable<IDataProviderSettings> DataProviders => Enumerable.Empty<IDataProviderSettings>();

        public string DefaultConfiguration => "svws";

        public string DefaultDataProvider => ProviderName.MySqlConnector;

        public IEnumerable<IConnectionStringSettings> ConnectionStrings
        {
            get
            {
                yield return new ConnectionStringSettings
                {
                    Name = "svws",
                    ProviderName = ProviderName.MySqlConnector,
                    ConnectionString = $"Server={host};Port={port};Database={database};User={username};Password={password};"
                };
            }
        }
    }
}