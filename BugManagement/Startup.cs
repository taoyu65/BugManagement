using BugManagement.Application;
using BugManagement.Application.Contract;
using BugManagement.Core.Context;
using BugManagement.Core.Dtos;
using BugManagement.Core.Entities;
using BugManagement.Core.Repository;
using BugManagement.Core.Seeder;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

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
            InitReflection(services);
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

            //<!-- AutoMapper -->
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Issue, IssueSummaryDashboardDto>()
                .ForMember(d => d.IssueSummary, opt => opt.MapFrom(s => s.Summary))
                .ForMember(d => d.Priority, opt => opt.MapFrom(s => s.Priority.Level))
                .ForMember(d => d.Assignee, opt => opt.MapFrom(s => s.Assignee.UserName))
                .ForMember(d => d.IssueType, opt => opt.MapFrom(s => s.IssueType.Name));
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "api/{controller=Home}/{action=Index}/{id?}");
            });
        }

        private void InitReflection(IServiceCollection services)
        {
            services.AddTransient<MyContext>();
            services.AddScoped<IDashboard, Dashboard>();
            services.AddScoped<IUser, Application.User>();

            services.AddScoped<IIssueRepository, IssueRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
