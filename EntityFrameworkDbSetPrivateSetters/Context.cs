using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace EntityFrameworkDbSetPrivateSetters
{
    public class Context : DbContext
    {
        public Context() 
            : base("EFPrivateSettersDb")
        {

        }

        public static Context Create()
        {
            return new Context();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonConfig());
            modelBuilder.Configurations.Add(new CustomerConfig());
            modelBuilder.Configurations.Add(new CityConfig());
            modelBuilder.Configurations.Add(new StateConfig());
            modelBuilder.Configurations.Add(new CountryConfig());
            //modelBuilder.Configurations.Add(new CategoryConfig());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Country> Countries { get; set; }
        //public DbSet<Category> Categories { get; set; }
    }
}