using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace EntityFrameworkDbSetPrivateSetters
{
    public class Context : DbContext
    {
        public Context() : base("ConnectionString")
        {

        }

        public static Context Create()
        {
            return new Context();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonConfig());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Person> People { get; set; }
    }
}