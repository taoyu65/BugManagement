using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using BugManagement.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugManagement.DbConfiguration
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
