using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugManagement.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Avatar { get; set; }
        public string Description { get; set; }
        public int ProjectLeaderId { get; set; }

        public User ProjectLeader { get; set; }
    }
}
