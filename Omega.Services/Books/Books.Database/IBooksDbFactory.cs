namespace Books.Database
{
    public interface IBooksDbFactory
    {
        IBooksDbStore OpenDbStore();

        IBooksDbSession OpenDbSession(IBooksDbStore dbStore);

        IBooksDbAsyncSession OpenDbAsyncSession(IBooksDbStore dbStore);
    }
}
