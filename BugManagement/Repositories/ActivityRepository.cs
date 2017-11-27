using BugManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BugManagement.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly MyContext _myContext;

        public ActivityRepository(MyContext myContext)
        {
            _myContext = myContext;
        }

        public IEnumerable<Activity> GetActivities()
        {
            return _myContext.Activities.OrderBy(x => x.Id).ToList();
        }

        public void Delete(Activity activity)
        {
            _myContext.Activities.Remove(activity);
        }

        public void Delete(int id)
        {
            //var activity = 
        }
    }
}
