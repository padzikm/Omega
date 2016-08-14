namespace Books.Databases.BooksDb
{
    public interface IBooksDbFactory
    {
        IBooksDbStore CreateDbStore();

        IBooksDbSession CreateDbSession(IBooksDbStore dbStore);

        IBooksDbAsyncSession CreateDbAsyncSession(IBooksDbStore dbStore);
    }
}
