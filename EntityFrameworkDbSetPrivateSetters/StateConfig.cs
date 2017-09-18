using System.Data.Entity.ModelConfiguration;

namespace EntityFrameworkDbSetPrivateSetters
{
    public class StateConfig : EntityTypeConfiguration<State>
    {
        public StateConfig()
        {
            HasKey(p => p.StateId);
        }
    }
}
