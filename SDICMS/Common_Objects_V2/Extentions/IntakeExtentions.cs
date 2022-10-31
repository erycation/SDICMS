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
        }
    }
}
