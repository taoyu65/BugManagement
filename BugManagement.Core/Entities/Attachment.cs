using System;

namespace BugManagement.Core.Entities
{
    public class Attachment
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
