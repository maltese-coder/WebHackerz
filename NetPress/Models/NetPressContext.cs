using NetPress.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace NetPress.DAL
{
    public class NetPressContextA : DbContext
    {

        public NetPressContextA() : base("NetPressContext")
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Posts> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}