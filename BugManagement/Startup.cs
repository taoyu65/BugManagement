using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NLog.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using BugManagement.Infrastructure.Context;
using BugManagement.Infrastructure.Seeder;

namespace BugManagement
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
            services.AddMvc();

            var connectionString = Configuration.GetConnectionString("bugManagementDbConnectionString");
            //services.AddDbContext<MyContext>(x => x.UseSqlServer(connectionString));

            ///re-locate the migrationAssembly back to the "BugManagement" namespace
            string assemblyName = "BugManagement";
            services.AddDbContext<MyContext>(options =>
                options.UseSqlServer(connectionString,
                    optionsBuilder =>
                        optionsBuilder.MigrationsAssembly(assemblyName)
                )
           );
            //Inject repository
            //services.AddScoped<IActivityRepository, ActivityRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
            ILoggerFactory loggerFactory,
            MyContext myContext)
        {
            //<!-- NLog -->
            ///loggerFactory.AddProvider(new NLogLoggerProvider());//OK as well
            loggerFactory.AddNLog();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages();

            //<!-- Seed -->
            myContext.SeedForContext();

            app.UseMvc();
        }
    }
}
