namespace BugManagement.Core.Entities
{
    public class ProjectVersion
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
    }
}
