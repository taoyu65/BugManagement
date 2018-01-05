using BugManagement.Core.Entities;

namespace BugManagement.Core.Dtos
{
    public class IssueSummaryDashboardDto
    {
        public int Id { get; set; }
        public string IssueSummary { get; set; }
        public string IssueType { get; set; }
        public string Priority { get; set; }
        public string Assignee { get; set; }
    }
}
