using Store.Model;
using System.Data.Entity.ModelConfiguration;

namespace Store.Data.Configuration
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("Categories");
            Property(g => g.Name).IsRequired().HasMaxLength(50);
        }
    }
}
