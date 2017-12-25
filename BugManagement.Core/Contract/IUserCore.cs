using System;
using System.Collections.Generic;
using System.Text;

namespace BugManagement.Core.Contract
{
    public interface IUserCore
    {
        void DeleteUserWithRoles(int id); 
    }
}
