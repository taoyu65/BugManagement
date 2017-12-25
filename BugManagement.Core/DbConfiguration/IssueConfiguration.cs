using BugManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BugManagement.Core.DbConfiguration
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
            //builder.Ignore(x => x.Reporter);
            //builder.Ignore(x => x.Assignee);
            builder.HasOne(x => x.Assignee)
                .WithMany(x => x.SuggestedIssues)
                .HasForeignKey(x => x.AssigneeUserId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Reporter)
                .WithMany(x => x.AssignedIssues)
                .HasForeignKey(x => x.ReporterUserId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
