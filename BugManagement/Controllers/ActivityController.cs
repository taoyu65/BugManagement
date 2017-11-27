using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BugManagement.Repositories;

namespace BugManagement.Controllers
{
    //[Produces("application/json")]
    [Route("api/activity")]
    public class ActivityController : Controller
    {
        private readonly IActivityRepository _activityRepository;

        public ActivityController(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }

        [HttpGet]
        public IActionResult GetActivity()
        {
            var activities = _activityRepository.GetActivities();
            //todo: DTO to be needed
            return Ok(activities);
        }

        // GET: api/Activity/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Activity
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Activity/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //todo: complete this and test
            //var activity = 
            //_activityRepository.Delete()
        }
    }
}
