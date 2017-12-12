using BugManagement.Core.Tools;

namespace BugManagement.Core.Entities
{
    public class Priority : Entity
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public string Icon { get; set; }
        public int Order { get; set; }
    }
}
