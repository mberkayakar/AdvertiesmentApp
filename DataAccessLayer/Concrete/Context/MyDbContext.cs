using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.Context
{
    public class MyDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-SKDUDAU;Database=advertiesmentapp; User ID=BERKAYAKAR;Password=111;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Model Configuration 
        //}

        #region DbSet List

        public DbSet<AdvertiesmentUser> AdvertiesmentUsers{ get; set; }
        public DbSet<AdvertiesmentUserStatus> AdvertiesmentUserStatuses { get; set; }
        public DbSet<Advertisement> Advertisements{ get; set; }
        public DbSet<AppRole> Roles { get; set; }
        public DbSet<AppUsersRoles> UsersRoles { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<MilitaryStatus> MilitaryStatuses { get; set; }
        public DbSet<ProvidedServices> ProvidedServices { get; set; }
        public DbSet<Users> Users { get; set; }









        #endregion
    }
}
