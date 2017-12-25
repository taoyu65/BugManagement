using BugManagement.Application.Contract;
using BugManagement.Core;
using BugManagement.Core.Repository;
using System;

namespace BugManagement.Application
{
    public class User : UserCore, IUser
    {
        public User(IUserRepository userRepository) : base(userRepository)
        {

        }

        public new void DeleteUserWithRoles(int id)
        {
            base.DeleteUserWithRoles(id);
        }
    }
}
