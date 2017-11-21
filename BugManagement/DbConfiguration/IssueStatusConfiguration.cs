using BugManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugManagement.DbConfiguration
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
