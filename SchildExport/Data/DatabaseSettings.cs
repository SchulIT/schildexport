using LinqToDB.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Data
{
    public class DatabaseSettings : ILinqToDBSettings
    {
        private string connectionString;

        public DatabaseSettings(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<IDataProviderSettings> DataProviders => Enumerable.Empty<IDataProviderSettings>();

        public string DefaultConfiguration => "default";

        public string DefaultDataProvider => "SqlServer";

        public IEnumerable<IConnectionStringSettings> ConnectionStrings
        {
            get
            {
                yield return new ConnectionStringSettings
                {
                    Name = "default",
                    ProviderName = "SqlServer",
                    ConnectionString = connectionString
                };
            }
        }
    }
}
