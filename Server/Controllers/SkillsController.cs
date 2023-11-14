using Microsoft.AspNetCore.Mvc;
using Server.Context;
using Server.DTOs.Skill;
using Server.Models;

namespace Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        AppDbContext context = new();

        [HttpGet]
        public IActionResult GetAll()
        {
            var skills = context.Skills.ToList();
            return Ok(skills);
        }

        [HttpPost]
        public IActionResult Add(AddSkillDto dto)
        {
            Skill skill = new()
            {
                Title = dto.Title,
                Description = dto.Description,
                Rating = dto.Rating
            };
            context.Add(skill);
            context.SaveChanges();
            return Ok(skill);
        }

        [HttpPost]
        public IActionResult Update(UpdateSkillDto dto)
        {
            var skill = context.Skills.Where(s => s.Id == dto.Id).FirstOrDefault();
            skill.Title = dto.Title;
            skill.Description = dto.Description;
            skill.Rating = dto.Rating;
            context.SaveChanges();
            return NoContent();
        }

        [HttpGet("id")]
        public IActionResult Delete(int id)
        {
            var skill = context.Skills.Where(s => s.Id == id).FirstOrDefault();
            context.Remove(skill);
            context.SaveChanges();
            return NoContent();
        }
    }
}
