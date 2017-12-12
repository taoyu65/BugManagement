using BugManagement.Core;
using BugManagement.Core.Context;
using Microsoft.EntityFrameworkCore;

namespace BugManagement.Core
{
    public class MyUnitOfWorkContext : UnitOfWorkContextBase
    {
        private MyContext _myContext;

        public MyUnitOfWorkContext(MyContext myContext)
        {
            _myContext = myContext;
            //_dbContext = new MyContext(new DbContextOptions<MyContext>());
        }

        protected override DbContext Context {
            get
            {
                return _myContext;
            }
        }

        //public MyContext MyContext
        //{
        //    get
        //    {
        //        return new MyContext(new DbContextOptions<MyContext>());
        //    }
        //    set
        //    {
        //        MyContext = value;
        //    }
        //}
    }
}
