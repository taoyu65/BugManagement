using BugManagement.Core.Dtos;

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
