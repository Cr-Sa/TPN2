using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TPN2.AccessData;
using TPN2.AccessData.Commands;
//using TPN2.AccessData.Queries;
using TPN2.Application.Services;
using TPN2.Domain.Commands;
//using TPN2.Domain.Queries;

namespace TPN2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            var connectionString = Configuration.GetSection("ConnectionString").Value;
            services.AddDbContext<CinedbContext>(options => options.UseSqlServer(connectionString));

            services.AddTransient<IGenericsRepository, GenericsRepository>();
            services.AddTransient<IFuncionesService, FuncionesService>();
            services.AddTransient<IPeliculasService, PeliculasService>();
            services.AddTransient<ITicketsService, TicketsService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
