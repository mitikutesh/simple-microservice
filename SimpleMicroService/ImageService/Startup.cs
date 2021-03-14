using ImageService.BusinessLogic.Data;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

namespace ImageService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private static string _connStr = @"Server=127.0.0.1,1401;Database=Master; User Id=SA; Password=root";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Configuration.GetConnectionString("DefaultConnection")
            services.AddScoped<IApplicationContext, ApplicationContext>();
            services.AddControllers();
            services.AddDbContext<ApplicationContext>(opt =>
                opt.UseSqlServer(_connStr,
                b => {
                    b
                        .MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)
                        .MigrationsHistoryTable("SimpleMicroServiceDbMigHistory")
                        .EnableRetryOnFailure(2);
                    }));
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
