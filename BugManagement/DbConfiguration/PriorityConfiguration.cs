using BugManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugManagement.DbConfiguration
{
    public class PriorityConfiguration: IEntityTypeConfiguration<Priority>
    {
        public void Configure(EntityTypeBuilder<Priority> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Level).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Icon).HasMaxLength(250);
        }
    }
}
