using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugManagement.Entities
{
    public class Priority
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public string Icon { get; set; }
        public int Order { get; set; }
    }
}
