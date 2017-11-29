using BugManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BugManagement.Infrastructure.DbConfiguration
{
    public class ProjectVersionConfiguration: IEntityTypeConfiguration<ProjectVersion>
    {
        public void Configure(EntityTypeBuilder<ProjectVersion> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(25);
            builder.Property(x => x.Description).HasMaxLength(250);
        }
    }
}
