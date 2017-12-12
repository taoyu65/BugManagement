using BugManagement.Core.Tools;

namespace BugManagement.Core.Entities
{
    public class ProjectVersion : Entity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
    }
}
