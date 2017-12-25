using BugManagement.Core.Contract;
using BugManagement.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugManagement.Core
{
    public abstract class UserCore : IUserCore
    {
        private IUserRepository UserReposiroty { get; set; }

        public UserCore(IUserRepository userRepository)
        {
            UserReposiroty = userRepository;
        }

        public void DeleteUserWithRoles(int id)
        {
            UserReposiroty.Delete(id);
        }
    }
}
