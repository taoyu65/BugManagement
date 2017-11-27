using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugManagement.Entities
{
    public class Activity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int IssueId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        public Issue Issue { get; set; }
        public User User { get; set; }
    }
}
