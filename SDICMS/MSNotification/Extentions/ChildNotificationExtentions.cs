using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MSChildNotification.NotificationDomain.Service;
using MSChildNotification.NotificationDomain.Service.Interface;
using MSChildNotification.Persistence;
using MSChildNotification.Repository;
using MSChildNotification.Repository.Interface;

namespace MSChildNotification.Extentions
{
    public static class ChildNotificationExtentions
    {
        public static void ConfigureChildNotificationExtention(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ChildNotificationDBContext>(options =>
            options.UseLazyLoadingProxies().UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IChildInformationRepository, ChildInformationRepository>();
            services.AddScoped<IChildInformationService, ChildInformationService>();
            services.AddScoped<IOffenseTypeRepository, OffenseTypeRepository>();
            services.AddScoped<IOffenseTypeService, OffenseTypeService>();

            var mapperConfig = new MapperConfiguration(mc =>
                    {
                        mc.AddProfile(new MappersExtentions());
                    });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
