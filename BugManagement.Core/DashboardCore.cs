using BugManagement.Core.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using BugManagement.Core.Dtos;
using BugManagement.Core.Entities;

namespace BugManagement.Core
{
    public abstract class DashboardCore : IDashboardCore
    {
        public IssueDashboard InitShow(int issueId)
        {
            if (issueId == 0)
            {

            }

            return new IssueDashboard {
                IssueSummaries = new List<IssueSummaryDashboard> {
                    new IssueSummaryDashboard {
                        IssueSummary = "This is issue summary1.",
                        Priority = "priority 1",
                        IssueType = "Bug1",
                        Assignee = "Tao has been assigned."
                    },
                    new IssueSummaryDashboard {
                        IssueSummary = "This is issue summary2.",
                        Priority = "priority 2",
                        IssueType = "Bug2",
                        Assignee = "Tao2 has been assigned."
                    }
                },
                Issue = new Issue {
                    IssueTypeId = 11,
                    AssigneeUserId = 11
                }
            };
        }
    }
}
