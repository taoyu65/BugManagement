using BugManagement.Core.Tools;

namespace BugManagement.Core.Entities
{
    public class Role : Entity
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
    }
}
