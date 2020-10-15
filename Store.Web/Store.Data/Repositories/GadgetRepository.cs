using Store.Data.Infrastructure;
using Store.Model;

namespace Store.Data.Repositories
{
    /// <summary>
    /// GadgetRepository supports the default operations using the default behaviour
    /// </summary>
    public class GadgetRepository : RepositoryBase<Gadget>, IGadgetRepository
    {
        public GadgetRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IGadgetRepository : IRepository<Gadget>
    {

    }
}
