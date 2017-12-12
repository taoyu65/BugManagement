using BugManagement.Core.Context;
using BugManagement.Core.Entities;

namespace BugManagement.Core.Repository
{
    public class IssueRepository : EFRepositoryBase<Issue>, IIssueRepository
    {
        public IssueRepository(MyContext myContext) : base(myContext)
        {
        }
    }
}
