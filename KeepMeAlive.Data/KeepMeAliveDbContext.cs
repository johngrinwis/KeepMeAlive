using KeepMeAlive.Domain;
using Microsoft.EntityFrameworkCore;

namespace KeepMeAlive.Data
{
    public class KeepMeAliveDbContext : DbContext
    {
        public DbSet<KeepAliveUser> KeepAliveUsers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = KeepMeAliveData; Trusted_Connection = True;");
        }
    }
}
