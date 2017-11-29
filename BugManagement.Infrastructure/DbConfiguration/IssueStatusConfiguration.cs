using BugManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BugManagement.Infrastructure.DbConfiguration
{
    public class IssueStatusConfiguration: IEntityTypeConfiguration<IssueStatus>
    {
        public void Configure(EntityTypeBuilder<IssueStatus> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.StatusName).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(250);
        }
    }
}
