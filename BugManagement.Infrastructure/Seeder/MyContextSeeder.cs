using BugManagement.Core.Entities;
using BugManagement.Infrastructure.Context;
using System.Collections.Generic;
using System.Linq;

namespace BugManagement.Infrastructure.Seeder
{
    public static class MyContextSeeder
    {
        public static void SeedForContext(this MyContext context)
        {
            //<!-- IssueType -->
            if (!context.IssueTypes.Any())
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
                context.IssueTypes.AddRange(IssueType);
                context.SaveChanges();
            }

            //<!-- ProjectVersion -->
            if (!context.ProjectVersions.Any())
            {
                var ProjectVersion = new List<ProjectVersion> {
                    new ProjectVersion {
                        Title = "Version 1.0",
                        Description = "This is the first version.",
                        Order = 0
                    },
                    new ProjectVersion {
                        Title = "Version 2.0",
                        Description = "Upgraded version, newest!",
                        Order = 1
                    }
                };
                context.ProjectVersions.AddRange(ProjectVersion);
                context.SaveChanges();
            }

            //<!-- Priority -->
            if (!context.Priorities.Any())
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
                context.Priorities.AddRange(Priority);
                context.SaveChanges();
            }

            //<!-- IssueStatus -->
            if (!context.IssueStatuses.Any())
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
                context.IssueStatuses.AddRange(IssueStatus);
                context.SaveChanges();
            }

            //<!-- User -->
            if (!context.Users.Any())
            {
                var users = new List<User> {
                    new User {
                        UserName = "admin1",
                        Password = "password1"
                    },
                    new User {
                        UserName = "admin2",
                        Password = "password2"
                    },
                    new User {
                        UserName = "admin3",
                        Password = "password3"
                    }
                };
                context.AddRange(users);
                context.SaveChanges();
            }

            //<!-- Project -->
            if (!context.Projects.Any())
            {

            }

            //<!-- Attachment -->
            if (!context.Attachments.Any())
            {

            }

            //<!-- Issue -->
            if (!context.Issues.Any())
            {
                var issues = new List<Issue> {
                    new Issue {
                        Summary = "this is bug 1",
                        Description = "bug 1 description",
                        AssigneeUserId = 1,
                        IssueTypeId = 1,
                        PriorityId = 1,
                        Label = "BugLabel",
                        ReporterUserId = 1,
                        ProjectVersionId = 1
                    },
                    new Issue {
                        Summary = "this is bug 2",
                        Description = "bug 2 description",
                        AssigneeUserId = 2,
                        IssueTypeId = 1,
                        PriorityId = 1,
                        Label = "BugLabel",
                        ReporterUserId = 2,
                        ProjectVersionId = 1
                    },
                    new Issue {
                        Summary = "this is bug 3",
                        Description = "bug 3 description",
                        AssigneeUserId = 3,
                        IssueTypeId = 1,
                        PriorityId = 1,
                        Label = "BugLabel",
                        ReporterUserId = 3,
                        ProjectVersionId = 1
                    },
                };
                context.Issues.AddRange(issues);
                context.SaveChanges();
            }

            //<!-- Activity -->
            if (!context.Activities.Any())
            {
                var activities = new List<Activity> {
                    new Activity {
                        Title = "add a comment1",
                        Content = "This is a comment1.",
                        Type = "comment",
                        IssueId = 1,
                        UserId = 1
                    },
                    new Activity {
                        Title = "add a comment2",
                        Content = "This is a comment2.",
                        Type = "comment",
                        IssueId = 2,
                        UserId = 2
                    },
                    new Activity {
                        Title = "add a comment3",
                        Content = "This is a comment3.",
                        Type = "comment",
                        IssueId = 3,
                        UserId = 3
                    },
                };
                context.Activities.AddRange(activities);
                context.SaveChanges();
            }

            //<!-- Role -->
            if (!context.Roles.Any())
            {

            }

            //<!-- Permission -->
            if (!context.Permissions.Any())
            {

            }
        }
    }
}
