using System.Data.Entity.ModelConfiguration;

namespace EntityFrameworkDbSetPrivateSetters
{
    public class CategoryConfig : EntityTypeConfiguration<Category>
    {
        public CategoryConfig()
        {
            HasKey(p => p.CategoryId);
        }
    }
}
