using BugManagement.Core.Tools;

namespace BugManagement.Core.Entities
{
    public class IssueStatus : Entity
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public string Description { get; set; }
    }
}
