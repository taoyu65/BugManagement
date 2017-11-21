using BugManagement.DbConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugManagement.Entities
{
    public class MyContext: DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
            Database.EnsureCreated();
            //Database.Migrate();   //also, using CLI update-database is OK
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new IssueTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectVersionConfiguration());
            modelBuilder.ApplyConfiguration(new PriorityConfiguration());
            modelBuilder.ApplyConfiguration(new IssueStatusConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new AttachmentConfiguration());
            modelBuilder.ApplyConfiguration(new IssueConfiguration());

        }

        public DbSet<IssueType> IssueType { get; set; }
        public DbSet<ProjectVersion> ProjectVersion { get; set; }
        public DbSet<Priority> Priority { get; set; }
        public DbSet<IssueStatus> IssueStatus { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Attachment> Attachment { get; set; }
        public DbSet<Issue> Issue { get; set; }

    }
}
