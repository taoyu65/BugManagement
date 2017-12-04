using BugManagement.Application.Contract;
using Microsoft.AspNetCore.Mvc;

namespace BugManagement.Controllers
{
    [Route("api/[controller]")]
    [Route("[controller]/[action]/{id?}")]
    public class DashboardController : Controller
    {
        
        private IDashboard _dashboard { get; set; }

        public DashboardController(IDashboard dashboard)
        {
            _dashboard = dashboard;
        }

        public IActionResult DashboardShow()
        {

            return Ok("tsst");
        }


        public IActionResult Page2()
        {

            return Ok(_dashboard.InitShow());
        }

        [HttpGet]
        public IActionResult Restful()
        {
            return Ok("restful");
        }
    }
}