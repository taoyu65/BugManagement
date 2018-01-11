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
    
        public DashboardController(IDashboard dashboard)
        {
            _dashboard = dashboard;
        }

        public IActionResult DashboardShow()
        {

            return Ok();
        }


        public IActionResult Page2()
        {
            return Ok(_dashboard.InitShow().IssueSummaries);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Persion persion)
        {
            return Ok("This is from returning: name is " + persion.name + "age: " + persion.age.ToString());
        }

        [HttpPost]
        public string PostTest(string a)
        {
            
            return "AAA:" + a;
        }

        [HttpGet]
        public IActionResult Restful()
        {
            return Ok("restful");
        }
    }

    public class Persion
    {
        public string name;
        public int age;
    }
}