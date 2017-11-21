using BugManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BugManagement.DbConfiguration
{
    public class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.RoleId).IsRequired();
            builder.Property(x => x.PermissionId).IsRequired();
        }
    }
}
