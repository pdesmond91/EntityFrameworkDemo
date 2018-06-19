using EF6Domain.Classes;
using System.Data.Entity;

namespace EF6Domain.DataModel
{
    public class NinjaContext : DbContext
    {
        public NinjaContext()
        {
            Database.SetInitializer(new NullDatabaseInitializer<NinjaContext>());
        }

        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<NinjaEquipment> Equipment { get; set; }
    }
}
