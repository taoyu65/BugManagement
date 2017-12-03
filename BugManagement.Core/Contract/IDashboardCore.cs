using BugManagement.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugManagement.Core.Contract
{
    public interface IDashboardCore
    {
        /// <summary>
        /// Get all data for dashboard
        /// </summary>
        /// <param name="issueId"></param>
        /// <returns></returns>
        IssueDashboard InitShow(int issueId);
    }
}
