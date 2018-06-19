using EF6Domain.Classes;
using System.Data.Entity;

namespace EF6Domain.DataModel
{
    public class GeDbContext : DbContext
    {

        public GeDbContext()
        {
            Database.SetInitializer(new NullDatabaseInitializer<GeDbContext>());
        }

        public DbSet<CUSTOMER> CUSTOMER { get; set; }
    }
}
