using System;
using System.Configuration;
using Raven.Client.Document;

namespace Books.DatabaseSetup
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Specify database parameter");
                return;
            }

            var dbKey = args[0];

            var dbName = ConfigurationManager.AppSettings[dbKey];

            if (dbName == null)
            {
                Console.WriteLine("Specify database name in app.config");
                return;
            }

            if (ConfigurationManager.ConnectionStrings[dbKey] == null)
            {
                Console.WriteLine("Specify database connection string in app.config");
                return;
            }

            Console.WriteLine("Specified database: {0}", dbName);

            var dbStore = new DocumentStore()
            {
                ConnectionStringName = dbKey,
            }.Initialize();

            dbStore.DatabaseCommands.GlobalAdmin.DeleteDatabase(dbName);

            Console.WriteLine("Database deleted successfully");

            dbStore.DatabaseCommands.GlobalAdmin.EnsureDatabaseExists(dbName);

            Console.WriteLine("Database created successfully");
        }
    }
}
