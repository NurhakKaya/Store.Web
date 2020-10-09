namespace Store.Data.Infrastructure
{
    /// <summary>
    /// Implementation of IDbFactory interface
    /// </summary>
    public class DbFactory : Disposable, IDbFactory
    {
        StoreEntities dbContext;

        public StoreEntities Init()
        {
            return dbContext ?? (dbContext = new StoreEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
