using System.Collections.Generic;

namespace BugManagement.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public ICollection<Activity> Activities { get; set; }
    }
}
