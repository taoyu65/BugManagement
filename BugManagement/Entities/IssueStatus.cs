using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugManagement.Entities
{
    public class IssueStatus
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public string Description { get; set; }
    }
}
