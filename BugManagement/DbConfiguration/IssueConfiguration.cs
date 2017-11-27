using BugManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BugManagement.DbConfiguration
{
    public class IssueConfiguration: IEntityTypeConfiguration<Issue>
    {
        public void Configure(EntityTypeBuilder<Issue> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Summary).IsRequired();
            builder.Property(x => x.IssueTypeId).IsRequired();
            builder.Property(x => x.ReporterUserId).IsRequired();
            builder.Property(x => x.Description).HasColumnType("text");
            builder.Property(x => x.ProjectVersionId).IsRequired();
            builder.Property(x => x.PriorityId).IsRequired();
        }
    }
}
