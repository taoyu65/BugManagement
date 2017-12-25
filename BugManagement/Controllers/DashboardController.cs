using BugManagement.Application.Contract;
using Microsoft.AspNetCore.Mvc;
using System.Composition;

namespace BugManagement.Controllers
{
    [Route("api/[controller]")]
    [Route("[controller]/[action]/{id?}")]
    public class DashboardController : Controller
    {
        
        private IDashboard _dashboard { get; set; }
    
        [Import]
        private ITest _test { get; set; }
        public DashboardController(IDashboard dashboard)
        {
            _dashboard = dashboard;
        }

        public IActionResult DashboardShow()
        {

            return Ok(_test.a());
        }


        public IActionResult Page2()
        {
            return Ok(_dashboard.InitShow());
        }

        [HttpGet]
        public IActionResult Restful()
        {
            return Ok("restful" + _test.a());
        }
    }

   [Export(typeof(ITest))]
    public class Test : ITest
    {
        public string a()
        {
            return "111";
        }
    }
   
    public interface ITest {
        string a();
    }
}