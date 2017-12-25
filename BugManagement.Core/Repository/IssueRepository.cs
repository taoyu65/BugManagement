using BugManagement.Core.Context;
using BugManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BugManagement.Core.Repository
{
    public class IssueRepository : EFRepositoryBase<Issue>, IIssueRepository
    {
        public IssueRepository(MyContext myContext) : base(myContext)
        {
            
        }

        public IQueryable<Issue> DashboardInfo()
        {
            return base.Entities
                .Include(x => x.Priority)
                .Include(x => x.IssueType)
                .Include(x => x.Assignee)
                .Include(x => x.Reporter)
                .AsNoTracking();
        }
    }
}
