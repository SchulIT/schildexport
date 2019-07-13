using System;
using System.Text;

namespace SchulIT.SchildExport.Data
{
    public class ConnectionStringBuilder
    {
        private string server;
        private string database;
        private string username;
        private string password;

        public ConnectionStringBuilder SetServer(string server)
        {
            this.server = server;
            return this;
        }

        public ConnectionStringBuilder SetDatabase(string database)
        {
            this.database = database;
            return this;
        }

        public ConnectionStringBuilder SetUsername(string username)
        {
            this.username = username;
            return this;
        }

        public ConnectionStringBuilder SetPassword(string password)
        {
            this.password = password;
            return this;
        }

        public string GetConnectionString()
        {
            var builder = new StringBuilder();

            if(string.IsNullOrWhiteSpace(server))
            {
                throw new InvalidOperationException("You must specify a server");
            }

            if(string.IsNullOrWhiteSpace(database))
            {
                throw new InvalidOperationException("Your must specify a database");
            }

            builder.Append($"Server={server};");
            builder.Append($"Database={database};");

            if (!string.IsNullOrEmpty(username))
            {
                builder.Append($"User={username};");
            }

            if (!string.IsNullOrEmpty(password))
            {
                builder.Append($"User={password};");
            }

            return builder.ToString();
        }
    }
}
