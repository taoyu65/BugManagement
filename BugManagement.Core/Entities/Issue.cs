using BugManagement.Core.Tools;
using System.Collections.Generic;

namespace BugManagement.Core.Entities
{
    public class Issue : Entity
    {
        public int Id { get; set; }
        public string Summary { get; set; }
        public int IssueTypeId { get; set; }
        public int ReporterUserId { get; set; }
        public string Description { get; set; }
        public int ProjectVersionId { get; set; }
        public int PriorityId { get; set; }
        public string Label { get; set; }
        public int AssigneeUserId { get; set; }

        public IssueType IssueType { get; set; }
        public User Reporter { get; set; }
        public ProjectVersion Version { get; set; }
        public Priority Priority { get; set; }
        public User Assignee { get; set; }

        public ICollection<Activity> Activities { get; set; }
    }
}
