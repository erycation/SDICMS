using Common_Objects_V2.Intake.Models;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Intake.Persistence
{
    public class IntakeDBContext : DbContext
    {

        public IntakeDBContext(DbContextOptions<IntakeDBContext> options) : base(options)
        {
            //optionsBuilder.ConfigureWarnings(warnings => warnings.Throw(CoreEventId.IncludeIgnoredWarning));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>()
        .HasKey(c => new { c.User_Id, c.Role_Id });
            //modelBuilder.Entity<StockCountSheetReportDto>().HasNoKey();
            //modelBuilder.Entity<StockTakingDto>().HasNoKey();
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }        
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        //to implement functions
        public virtual DbSet<Municipality> Municipalities { get; set; }        
        public virtual DbSet<Area> Areas { get; set; }
        //end implemenmt functions
        public virtual DbSet<LocalMunicipality> LocalMunicipalities { get; set; }
        public virtual DbSet<Town> Towns { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }


    }
}
