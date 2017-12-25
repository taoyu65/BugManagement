using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BugManagement.Application.Contract;

namespace BugManagement.Controllers
{
    [Route("api/[controller]")]
    [Route("[controller]/[action]/{id?}")]
    public class UserController : Controller
    {
        private IUser _IUser { get; set; }

        public UserController(IUser iUser)
        {
            _IUser = iUser;
        }


    }
}