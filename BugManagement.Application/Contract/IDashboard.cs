using BugManagement.Core.Contract;
using BugManagement.Core.Dtos;

namespace BugManagement.Application.Contract
{
    public interface IDashboard : IDashboardCore
    {
        IssueDashboardDto InitShow();
        new IssueDashboardDto InitShow(int issueId);
    }
}
