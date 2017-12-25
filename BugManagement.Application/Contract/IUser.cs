using BugManagement.Core.Contract;

namespace BugManagement.Application.Contract
{
    public interface IUser : IUserCore
    {
        new void DeleteUserWithRoles(int id);
    }
}
