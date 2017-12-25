using BugManagement.Core.Entities;
using System.Linq;

namespace BugManagement.Core.Repository
{
    public interface IIssueRepository : IRepository<Issue>
    {
        IQueryable<Issue> DashboardInfo();
    }
}
