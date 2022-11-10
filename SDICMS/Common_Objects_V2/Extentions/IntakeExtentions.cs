using Common_Objects_V2.Intake.Persistence;
using Common_Objects_V2.Intake.Repository;
using Common_Objects_V2.Intake.Repository.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Common_Objects_V2.Extentions
{
    public static class IntakeExtentions
    {
        public static void ConfigureIntakeCommonExtention(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<IntakeDBContext>(options =>
            options.UseLazyLoadingProxies().UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IUserRepository, UserRepository>();            
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IProvinceRepository, ProvinceRepository>();
            services.AddScoped<IDistrictRepository, DistrictRepository>();
            services.AddScoped<IMunicipalityRepository, MunicipalityRepository>();
            services.AddScoped<ILocalMunicipalityRepository, LocalMunicipalityRepository>();
            services.AddScoped<IAreaRepository, AreaRepository>();
            services.AddScoped<ITownRepository, TownRepository>();
            services.AddScoped<IOrganizationRepository, OrganizationRepository>();
            services.AddScoped<IMenuAccessRepository, MenuAccessRepository>();
            services.AddScoped<IMenuAccessRoleRepository, MenuAccessRoleRepository>();
            services.AddScoped<IGenderRepository, GenderRepository>();
            services.AddScoped<IRaceRepository, RaceRepository>();
            services.AddScoped<IReligionRepository, ReligionRepository>();
            services.AddScoped<ISchoolTypeRepository, SchoolTypeRepository>();
            services.AddScoped<ISchoolRepository, SchoolRepository>();
            services.AddScoped<IGradeRepository, GradeRepository>();
            services.AddScoped<IMaritalStatusRepository, MaritalStatusRepository>();
            services.AddScoped<ISkinColorRepository, SkinColorRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IAddressTypeRepository, AddressTypeRepository>();
            services.AddScoped<IAllergyRepository, AllergyRepository>();
            services.AddScoped<IAuditTrialRepository, AuditTrialRepository>();
            services.AddScoped<IContactTypeRepository, ContactTypeRepository>();
            services.AddScoped<ICitizenshipRepository, CitizenshipRepository>();
            services.AddScoped<IPopulationGroupRepository, PopulationGroupRepository>();
            services.AddScoped<IRelationshipTypeRepository, RelationshipTypeRepository>();
            services.AddScoped<IIncomeRangeRepository, IncomeRangeRepository>();
            services.AddScoped<IDisabilityRepository, DisabilityRepository>();
            services.AddScoped<IDisabilityTypeRepository, DisabilityTypeRepository>();
            services.AddScoped<IDeceaseRepository, DeceaseRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        }
    }
}
