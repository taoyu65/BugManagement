using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Composition;
using BugManagement.Application;
using BugManagement.Application.Contract;
using BugManagement.Core.Dtos;

namespace BugManagement.Controllers
{
    [Route("api/[controller]")]
    [Route("[controller]/[action]/{id?}")]
    public class DashboardController : Controller
    {
        [Import]
        public IDashboard Dashboard { get; set; }

        public IActionResult DashboardShow()
        {

            return Ok("tsst");
        }

       
        public IActionResult Page2()
        {
            IDashboard id = new Dashboard();
            IssueDashboard result = id.InitShow();
            return Ok(result);
        }

        [HttpGet]
        public IActionResult Restful()
        {
            return Ok("restful");
        }
    }
}