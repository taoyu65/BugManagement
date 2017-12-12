using BugManagement.Core.Tools;

namespace BugManagement.Core.Entities
{
    public class RolePermission : Entity
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        public Role Role { get; set; }
        public Permission Permission { get; set; }
    }
}
