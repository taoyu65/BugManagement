using BugManagement.Core.Entities;
using System.Collections.Generic;

namespace BugManagement.Core.Dtos
{
    public class IssueDashboardDto
    {
        public ICollection<IssueSummaryDashboardDto> IssueSummaries { get; set; }
        public Issue Issue { get; set; }

        public IssueDashboardDto()
        {
            IssueSummaries = new List<IssueSummaryDashboardDto>();
        }
    }
}
