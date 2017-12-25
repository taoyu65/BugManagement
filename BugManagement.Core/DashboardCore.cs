using BugManagement.Core.Contract;
using BugManagement.Core.Dtos;
using BugManagement.Core.Entities;
using BugManagement.Core.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BugManagement.Core
{
    public abstract class DashboardCore : IDashboardCore
    {
        #region Property
   
        private IIssueRepository IssueRepository { get; set; }

        #endregion

        #region Method

        //public DashboardCore(IIssueRepository issueRepository)
        //{
        //    IssueRepository = issueRepository;
        //    //todo - look book about DI, and can try microsoft.composition use for MEF
        //}

        public DashboardCore (IIssueRepository issueRepository)
        {
            IssueRepository = issueRepository;
        }

        public IssueDashboard InitShow(int issueId)
        {
            if (issueId == 0)
            {
            }

            IQueryable<Issue> issues = IssueRepository.DashboardInfo();

            IssueDashboard issueDashboard = new IssueDashboard();
            Issue showedIssue = issues.FirstOrDefault();
            issueDashboard.Issue = showedIssue;
            foreach (Issue issue in issues)
            {
                var issueSummaryDashboard = new IssueSummaryDashboard {
                    Id = issue.Id,
                    IssueSummary = issue.Summary,
                    Priority = issue.Priority.Level,
                    IssueType = issue.IssueType.Name,
                    Assignee = issue.Assignee.UserName
                };
                issueDashboard.IssueSummaries.Add(issueSummaryDashboard);
            }
            return issueDashboard;
            //return new IssueDashboard {
            //    IssueSummaries = new List<IssueSummaryDashboard> {
            //        new IssueSummaryDashboard {
            //            IssueSummary = "This is issue summary1.",
            //            Priority = "priority 1",
            //            IssueType = "Bug1",
            //            Assignee = "Tao has been assigned."
            //        },
            //        new IssueSummaryDashboard {
            //            IssueSummary = "This is issue summary2.",
            //            Priority = "priority 2",
            //            IssueType = "Bug2",
            //            Assignee = "Tao2 has been assigned."
            //        }
            //    },
            //    Issue = new Issue {
            //        IssueTypeId = 11,
            //        AssigneeUserId = 11
            //    }
            //};
        }

        #endregion
    }
}
