using Microsoft.EntityFrameworkCore;
using MSChildNotification.NotificationDomain.Model;

namespace MSChildNotification.Persistence
{
    public class ChildNotificationDBContext : DbContext
    {

        public ChildNotificationDBContext(DbContextOptions<ChildNotificationDBContext> options) : base(options)
        {
            //optionsBuilder.ConfigureWarnings(warnings => warnings.Throw(CoreEventId.IncludeIgnoredWarning));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<UserRole>()
            //        .HasKey(c => new { c.User_Id, c.Role_Id });
            //modelBuilder.Entity<MenuAccessRole>()
            //        .HasKey(c => new { c.Menu_Access_Id, c.Role_Id });
            //modelBuilder.Entity<StockCountSheetReportDto>().HasNoKey();
            modelBuilder.Entity<NotificationCase>().HasNoKey();
        }

        public virtual DbSet<ChildInformation> ChildInformations { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<IdentityType> IdentityTypes { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<PoliceStation> PoliceStations { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Race> Races { get; set; }
        public virtual DbSet<NotificationCase> NotificationCases { get; set; }
        public virtual DbSet<OffenseType> OffenseTypes { get; set; }

    }
}
