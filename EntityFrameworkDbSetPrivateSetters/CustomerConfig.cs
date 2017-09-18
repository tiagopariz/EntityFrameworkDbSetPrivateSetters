using System.Data.Entity.ModelConfiguration;

namespace EntityFrameworkDbSetPrivateSetters
{
    public class CustomerConfig : EntityTypeConfiguration<Customer>
    {
        public CustomerConfig()
        {
            HasKey(p => p.CustomerId);
        }
    }
}
