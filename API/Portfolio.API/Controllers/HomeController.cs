using Microsoft.AspNetCore.Mvc;
using Portfolio.API.Context;

namespace Portfolio.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetSkills()
        {
            var skills = _context.Skills.ToList();
            return Ok(skills);
        }

        [HttpGet]
        public IActionResult GetServices()
        {
            var services = _context.Services.ToList();
            return Ok(services);
        }

        [HttpGet]
        public IActionResult GetEducations()
        {
            var educations = _context.Educations.ToList();
            return Ok(educations);
        }

        [HttpGet]
        public IActionResult GetExperiences()
        {
            var experiences = _context.Experiences.ToList();
            return Ok(experiences);
        }

        [HttpGet]
        public IActionResult GetProjects()
        {
            var projects = _context.Projects.ToList();
            return Ok(projects);
        }

        [HttpGet("id")]
        public IActionResult GetSettings(int id)
        {
            var settings = _context.Settings.Where(s => s.Id == id).FirstOrDefault();
            return Ok(settings);
        }
    }
}
