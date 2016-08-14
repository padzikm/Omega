using Raven.Client.Document;

namespace Books.Databases.BooksDb
{
    class BooksDbFactory : IBooksDbFactory
    {
        public IBooksDbStore CreateDbStore()
        {
            var dbStore = new DocumentStore()
            {
                ConnectionStringName = "BooksDatabase",
            }.Initialize(true);

            return (IBooksDbStore)dbStore;
        }

        public IBooksDbSession CreateDbSession(IBooksDbStore dbStore)
        {
            var session = dbStore.OpenSession();

            return (IBooksDbSession)session;
        }

        public IBooksDbAsyncSession CreateDbAsyncSession(IBooksDbStore dbStore)
        {
            var session = dbStore.OpenAsyncSession();
            
            return (IBooksDbAsyncSession)session;
        }
    }
}
