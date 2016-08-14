using Raven.Client.Document;

namespace Books.Database
{
    class BooksDbFactory : IBooksDbFactory
    {
        public IBooksDbStore OpenDbStore()
        {
            var dbStore = new DocumentStore()
            {
                ConnectionStringName = "BooksDatabase",
            }.Initialize(true);

            return (IBooksDbStore)dbStore;
        }

        public IBooksDbSession OpenDbSession(IBooksDbStore dbStore)
        {
            var session = dbStore.OpenSession();

            return (IBooksDbSession)session;
        }

        public IBooksDbAsyncSession OpenDbAsyncSession(IBooksDbStore dbStore)
        {
            var session = dbStore.OpenAsyncSession();
            
            return (IBooksDbAsyncSession)session;
        }
    }
}
