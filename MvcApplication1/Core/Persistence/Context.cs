using System.Data.Entity;
using Core.Model;

namespace Core.Persistence
{
    public class Context : DbContext
    {
        public DbSet<User2> User2s { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>());
        }
    }
}