using BugManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BugManagement.Core.DbConfiguration
{
    public class AttachmentConfiguration: IEntityTypeConfiguration<Attachment>
    {
        public void Configure(EntityTypeBuilder<Attachment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FileName).IsRequired();
            builder.Property(x => x.Path).IsRequired();
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
        }
    }
}
