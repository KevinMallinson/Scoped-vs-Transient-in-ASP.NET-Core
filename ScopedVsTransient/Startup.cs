using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ScopedVsTransient.Classes;

namespace ScopedVsTransient
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //services.AddTransient<PersonDep>();
            //services.AddTransient<PetDep>();
            //services.AddTransient<JobDep>();
            //services.AddTransient<SampleService>();

            services.AddScoped<PersonDep>();
            services.AddScoped<PetDep>();
            services.AddScoped<JobDep>();
            services.AddScoped<SampleService>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
