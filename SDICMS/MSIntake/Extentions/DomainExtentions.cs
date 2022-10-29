using AutoMapper;
using MSIntake.IntakeDomain.Services;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.Extentions
{
    public static class DomainExtentions
    {
        public static void ConfigureIntakeDomainExtention(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddSingleton<IAuthManager>(new AuthManager(configuration.GetSection("JWTSettings:SecretKey").Value));
            services.AddScoped<IAuthenticateService, AuthenticateService>();
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IProvinceService, ProvinceService>();
            services.AddScoped<IDistrictService, DistrictService>();
            services.AddScoped<ILocalMunicipalityService, LocalMunicipalityService>();
            services.AddScoped<IOrganizationService, OrganizationService>();
            services.AddScoped<ITownService, TownService>();

            var mapperConfig = new MapperConfiguration(mc =>
                            {
                                mc.AddProfile(new MappersExtentions());
                            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}