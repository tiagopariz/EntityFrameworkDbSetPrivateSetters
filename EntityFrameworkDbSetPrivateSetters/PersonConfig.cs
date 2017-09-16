using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EntityFrameworkDbSetPrivateSetters
{
    public class PersonConfig : EntityTypeConfiguration<Person>
    {
        public PersonConfig()
        {
            HasKey(p => p.PersonId);

            //Property(p => p.PersonId)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }

        
    }
}
