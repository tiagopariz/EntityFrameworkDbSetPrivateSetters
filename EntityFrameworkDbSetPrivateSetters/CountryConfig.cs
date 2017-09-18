using System.Data.Entity.ModelConfiguration;

namespace EntityFrameworkDbSetPrivateSetters
{
    public class CountryConfig : EntityTypeConfiguration<Country>
    {
        public CountryConfig()
        {
            HasKey(p => p.CountryId);
        }
    }
}
