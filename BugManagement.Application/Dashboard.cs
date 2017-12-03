using BugManagement.Application.Contract;
using BugManagement.Core;
using BugManagement.Core.Dtos;
using System.Composition;

namespace BugManagement.Application
{
    [Export(typeof (IDashboard))]
    public class Dashboard : DashboardCore, IDashboard
    {
        public IssueDashboard InitShow()
        {
            return InitShow(0);
        }

        public new IssueDashboard InitShow(int issueId)
        {
            IssueDashboard IssueDashboard = base.InitShow(issueId);
            IssueDashboard.Issue.Description = "Add description!";
            return IssueDashboard;
        }
    }
}
