using BugManagement.Core.Tools;

namespace BugManagement.Core.Entities
{
    public class Permission : Entity
    {
        public int Id { get; set; }
        public string PermissionName { get; set; }
        public string Description { get; set; }
    }
}
