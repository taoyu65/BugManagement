using BugManagement.Core.Tools;

namespace BugManagement.Core.Entities
{
    public class Project : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Avatar { get; set; }
        public string Description { get; set; }
        public int ProjectLeaderId { get; set; }

        public User ProjectLeader { get; set; }
    }
}
