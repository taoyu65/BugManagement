using BugManagement.Entities;
using System.Collections.Generic;

namespace BugManagement.Repositories
{
    public interface IActivityRepository
    {

        IEnumerable<Activity> GetActivities();
        void Delete(Activity activity);
    }
}
