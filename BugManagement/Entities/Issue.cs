using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugManagement.Entities
{
    public class Issue
    {
        public int Id { get; set; }
        public string Summary { get; set; }
        public int IssueTypeId { get; set; }
        public int ReporterId { get; set; }
        public string Description { get; set; }
        public int VersionId { get; set; }
        public int PriorityId { get; set; }
        public string Label { get; set; }
        public int AttachmentId { get; set; }
        public int AssigneeId { get; set; }

        public IssueType IssueType { get; set; }
        public User Reporter { get; set; }
        public Version Version { get; set; }
        public Priority Priority { get; set; }
        public Attachment Attachment { get; set; }
        public User Assignee { get; set; }
    }
}
