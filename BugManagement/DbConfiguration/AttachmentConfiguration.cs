using System;
using BugManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BugManagement.DbConfiguration
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
