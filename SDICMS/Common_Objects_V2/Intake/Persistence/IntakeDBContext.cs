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
            modelBuilder.Entity<MenuAccessRole>()
                    .HasKey(c => new { c.Menu_Access_Id, c.Role_Id });
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
        public virtual DbSet<MenuAccess> MenuAccess { get; set; }
        public virtual DbSet<MenuAccessRole> MenuAccessRoles { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Race> Races { get; set; }
        public virtual DbSet<Religion> Religions { get; set; }
        public virtual DbSet<SchoolType> SchoolTypes { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<MaritalStatus> MaritalStatuss { get; set; }
        public virtual DbSet<SkinColor> SkinColors { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<Allergy> Allergies { get; set; }
        public virtual DbSet<AuditTrial> AuditTrials { get; set; }
        public virtual DbSet<ContactType> ContactTypes { get; set; }
        public virtual DbSet<Citizenship> Citizenships { get; set; }
        public virtual DbSet<PopulationGroup> PopulationGroups { get; set; }
        public virtual DbSet<RelationshipType> RelationshipTypes { get; set; }
        public virtual DbSet<IncomeRange> IncomeRanges { get; set; }
        public virtual DbSet<Disability> Disabilities { get; set; }
        public virtual DbSet<DisabilityType> DisabilityTypes { get; set; }
        public virtual DbSet<Decease> Deceases { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        
    }    
}
