using System.Data.Entity.ModelConfiguration;

namespace EntityFrameworkDbSetPrivateSetters
{
    public class CityConfig : EntityTypeConfiguration<City>
    {
        public CityConfig()
        {
            HasKey(p => p.CityId);
        }
    }
}
