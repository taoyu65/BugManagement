using BugManagement.Core.Contract;
using BugManagement.Core.Dtos;

namespace BugManagement.Application.Contract
{
    public interface IDashboard : IDashboardCore
    {
        IssueDashboard InitShow();
        new IssueDashboard InitShow(int issueId);
    }
}
