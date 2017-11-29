using BugManagement.Core.Entities;

namespace BugManagement.Application.Dtos
{
    public class IssueSummaryDashboard
    {
        public int Id { get; set; }
        public string Summary { get; set; }
        public int IssueTypeId { get; set; }
        public int PriorityId { get; set; }


        public IssueType IssueType { get; set; }
        public Priority Priority { get; set; }
    }
}
