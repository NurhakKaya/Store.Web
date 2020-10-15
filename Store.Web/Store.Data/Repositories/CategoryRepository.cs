using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Linq;

namespace Store.Data.Repositories
{
    /// <summary>
    /// CategoryRepository extends default operations (GetCategoryByName) and overrides teh default Update operation.
    /// We should add a repository for each of Model classes, hence each repository of tyep T is responsible to manipulate a specific DbSet through
    /// the DbContext.Set<T>.
    /// </summary>
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Category GetCategoryByName(string categoryName)
        {
            var category = this.DbContext.Categories.Where(c => c.Name == categoryName).FirstOrDefault();

            return category;
        }

        public override void Update(Category entity)
        {
            entity.DateUpdated = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetCategoryByName(string categoryName);
    }
}
