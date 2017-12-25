using BugManagement.Core.Entities;
using System.Collections.Generic;

namespace BugManagement.Core.Dtos
{
    public class IssueDashboard
    {
        public ICollection<IssueSummaryDashboard> IssueSummaries { get; set; }
        public Issue Issue { get; set; }

        public IssueDashboard()
        {
            IssueSummaries = new List<IssueSummaryDashboard>();
        }
    }
}
