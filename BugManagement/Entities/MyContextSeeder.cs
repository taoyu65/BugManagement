using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugManagement.Entities
{
    public static class MyContextSeeder
    {
        public static void SeedForContext(this MyContext context)
        {
            //<!-- IssueType -->
            if (!context.IssueType.Any())
            {
                var IssueType = new List<IssueType> {
                    new IssueType {
                        Name = "Suggestion",
                        Description = "Tell me your story, and gives some suggestions!"
                    },
                    new IssueType {
                        Name = "Bug",
                        Description = "Problem which you've found."
                    },
                    new IssueType {
                        Name = "Epic",
                        Description = "Big problem that need to be broken down."
                    },
                    new IssueType {
                        Name = "Task",
                        Description = "A task need to be done."
                    },
                    new IssueType {
                        Name = "Question",
                        Description = "A question or concern that relating the application."
                    }
                };
                context.IssueType.AddRange(IssueType);
                context.SaveChanges();
            }

            //<!-- ProjectVersion -->
            if (!context.ProjectVersion.Any())
            {
                var ProjectVersion = new List<ProjectVersion> {
                    new ProjectVersion {
                        Title = "Version 1.0",
                        Description = "This is the first version.",
                        Order = 0
                    },
                    new ProjectVersion {
                        Title = "Version 2.0",
                        Description = "Upgrated version, newest!",
                        Order = 1
                    }
                };
                context.ProjectVersion.AddRange(ProjectVersion);
                context.SaveChanges();
            }

            //<!-- Priority -->
            if (!context.Priority.Any())
            {
                var Priority = new List<Priority> {
                    new Priority {
                        Level = "Highest",
                        Icon = "",
                        Order = 0
                    },
                    new Priority {
                        Level = "High",
                        Icon = "",
                        Order = 1
                    },
                     new Priority {
                         Level = "Medium",
                         Icon = "",
                         Order = 2
                     },
                     new Priority {
                         Level = "Low",
                         Icon = "",
                         Order = 3
                     },
                     new Priority {
                         Level = "Lowest",
                         Icon = "",
                         Order = 4
                     }
                };
                context.Priority.AddRange(Priority);
                context.SaveChanges();
            }

            //<!-- IssueStatus -->
            if (!context.IssueStatus.Any())
            {
                var IssueStatus = new List<IssueStatus> {
                    new IssueStatus {
                        StatusName = "Open",
                        Description = "open"
                    },
                    new IssueStatus {
                        StatusName = "In Progress",
                        Description = "in progress"
                    },
                    new IssueStatus {
                        StatusName = "Reopen",
                        Description = "reopen"
                    },
                    new IssueStatus {
                        StatusName = "Resolved",
                        Description = "resolved"
                    },
                    new IssueStatus {
                        StatusName = "Closed",
                        Description = "closed"
                    },
                    new IssueStatus {
                        StatusName = "To Do",
                        Description = "to do"
                    },
                    new IssueStatus {
                        StatusName = "Done",
                        Description = "done"
                    }
                };
                context.IssueStatus.AddRange(IssueStatus);
                context.SaveChanges();
            }

            //<!-- User -->
            if (!context.User.Any())
            {

            }

            //<!-- Project -->
            if (!context.Project.Any())
            {

            }

            //<!-- Attachment -->
            if (!context.Attachment.Any())
            {

            }

            //<!-- Issue -->
            if (!context.Issue.Any())
            {

            }

            //<!-- Activity -->
            if (!context.Activity.Any())
            {

            }

            //<!-- Role -->
            if (!context.Role.Any())
            {

            }

            //<!-- Permission -->
            if (!context.Permission.Any())
            {

            }
        }
    }
}
