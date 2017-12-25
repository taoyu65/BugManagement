using BugManagement.Core.Context;
using BugManagement.Core.Entities;

namespace BugManagement.Core.Repository
{
    public class UserRepository : EFRepositoryBase<User>, IUserRepository
    {
        public UserRepository(MyContext myContext) : base(myContext)
        {
        }
    }
}
