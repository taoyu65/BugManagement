using BugManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugManagement.Application.Dtos
{
    public class IssueDashboard
    {
        public List<IssueSummaryDashboard> IssueSummary { get; set; }
        public Issue MyProperty { get; set; }
    }
}
