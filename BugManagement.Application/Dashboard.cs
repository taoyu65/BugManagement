using BugManagement.Application.Contract;
using BugManagement.Core;
using BugManagement.Core.Dtos;
using BugManagement.Core.Repository;

namespace BugManagement.Application
{
    public class Dashboard :  DashboardCore, IDashboard
    {
        public Dashboard(IIssueRepository issueRepository) : base(issueRepository)
        {
        }

        public IssueDashboardDto InitShow()
        {
            return InitShow(0);
        }

        public new IssueDashboardDto InitShow(int issueId)
        {
            IssueDashboardDto IssueDashboard = base.InitShow(issueId);
            IssueDashboard.Issue.Description = "Add description!";
            return IssueDashboard;
        }
    }
}
