using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Clinica.API.Data;
using Clinica.Data.DependencyInjection;


namespace Clinica.API
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
            // Use the Threenine.Data Dependency Injection to set up the Unit of Work
           //services.AddDbContext<DataContexto>(x => x.UseSqlServer(Configuration.GetConnectionString("ClinicaDB"))).AddUnitOfWork<DataContexto>();

            services.AddDbContext<DataContexto>(x => x.UseSqlite("Data Source=Clinica.db"))
                    .AddUnitOfWork<DataContexto>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            // Use Threenine.Map to wire up the Automapper mappings
            //MapConfigurationFactory.Scan<Startup>();

            // Ensure the Database is created
            /* 
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                serviceScope.ServiceProvider.GetService<DataContexto>().Database.EnsureCreated();
            } 
            */


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
