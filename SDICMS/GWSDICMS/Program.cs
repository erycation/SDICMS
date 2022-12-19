/*using Ocelot.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);





// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

*/

using Ocelot.DependencyInjection;

namespace GWSDICMS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //         .ConfigureAppConfiguration((hostBuilderContext, configurationBinder) =>
        //         {
        //             configurationBinder.AddJsonFile("configuration.json", false, true);
        //         })
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });


        public static IHostBuilder CreateHostBuilder(string[] args) =>
              Host.CreateDefaultBuilder(args)
                 .ConfigureWebHostDefaults(webBuilder =>
                 {
                     webBuilder
                       .ConfigureAppConfiguration((hostingContext, config) =>
                       {
                           config
                               .SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
                           .AddOcelot("ConfigRoutes", hostingContext.HostingEnvironment)
                           .AddEnvironmentVariables();

                       });

                     webBuilder.UseStartup<Startup>();
                 });
    }
}
