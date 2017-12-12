using BugManagement.Core.Tools;
using System.Collections.Generic;

namespace BugManagement.Core.Entities
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public ICollection<Activity> Activities { get; set; }
    }
}
