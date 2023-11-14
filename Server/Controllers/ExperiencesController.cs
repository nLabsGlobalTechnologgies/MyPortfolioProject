using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Context;
using Server.DTOs.Experience;
using Server.Models;

namespace Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExperiencesController : ControllerBase
    {
        AppDbContext context = new();
        [HttpGet]
        public IActionResult GetAll()
        {
            var experiences = context.Experiences.ToList();
            return Ok(experiences);
        }

        [HttpPost]
        public IActionResult Add(AddExperienceDto dto)
        {
            Experience experience = new() 
            {
                Type = dto.Type,
                Title = dto.Title,
                Description = dto.Description,
                StartMonth = dto.StartMonth,
                StartYear = dto.StartYear,
                EndMonth = dto.EndMonth,
                EndYear = dto.EndYear
            };
            context.Add(experience);
            context.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IActionResult Update(UpdateExperienceDto dto)
        {
            var experience = context.Experiences.Where(e => e.Id == dto.Id).FirstOrDefault();
            experience.Type = dto.Type;
            experience.Title = dto.Title;
            experience.Description = dto.Description;
            experience.StartMonth = dto.StartMonth;
            experience.StartYear = dto.StartYear;
            experience.EndMonth = dto.EndMonth;
            experience.EndYear = dto.EndYear;
            experience.UpdatedDate = dto.UpdatedDate;
            context.SaveChanges();
            return NoContent();
        }

        [HttpGet("id")]
        public IActionResult Delete(int id)
        {
            var experience = context.Experiences.Where(e => e.Id == id).FirstOrDefault();
            context.Remove(experience);
            context.SaveChanges();
            return NoContent();
        }
    }
}
