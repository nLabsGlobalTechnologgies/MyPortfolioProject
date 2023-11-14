using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Context;
using Server.DTOs.Project;
using Server.Models;

namespace Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        AppDbContext context = new();

        [HttpGet]
        public IActionResult GetAll()
        {
            var projects = context.Projects
                .Where(p => p.ProjectApproaches.Any() || p.ProjectPrinciples.Any() || p.ProjectTechnologgies.Any())
                .Include(p => p.ProjectApproaches)
                .Include(p => p.ProjectPrinciples)
                .Include(p => p.ProjectTechnologgies)
                .ToList();

            return Ok(projects);
        }


        [HttpPost]
        public IActionResult Add(AddProjectDto request)
        {
            Project project = new()
            {
                Title = request.Title,
                CoverImageUrl = request.CoverImageUrl,
                Image = request.Image,
                Link = request.Link,
                Github = request.Github
            };
            context.Add(project);
            if (request.ProjectApproaches != null)
            {
                foreach (var approach in request.ProjectApproaches)
                {
                    project.ProjectApproaches.Add(new ProjectApproachy
                    {
                        ProjectId = approach.ProjectId,
                        Key = approach.Key,
                        Value = approach.Value
                    });
                }
            }
            if (request.ProjectPrinciples != null)
            {
                foreach (var principle in request.ProjectPrinciples)
                {
                    project.ProjectPrinciples.Add(new ProjectPrinciple
                    {
                        ProjectId = principle.ProjectId,
                        Key = principle.Key,
                        Value = principle.Value
                    });
                }
            }
            if (request.ProjectTechnologgies != null)
            {
                foreach (var technologgy in request.ProjectTechnologgies)
                {
                    project.ProjectTechnologgies.Add(new ProjectTechnologgy
                    {
                        ProjectId = technologgy.ProjectId,
                        Key = technologgy.Key,
                        Value = technologgy.Value
                    });
                }
            }
            context.SaveChanges();
            return NoContent();
        }

        [HttpPost]
        public IActionResult Update(UpdateProjectDto request)
        {
            var existingProject = context.Projects
                .Include(p => p.ProjectApproaches)
                .Include(p => p.ProjectPrinciples)
                .Include(p => p.ProjectTechnologgies)
                .FirstOrDefault(p => p.Id == request.Id);

            if (existingProject == null)
            {
                return NotFound();
            }

            context.ProjectApproachies.RemoveRange(existingProject.ProjectApproaches);
            context.ProjectPrinciples.RemoveRange(existingProject.ProjectPrinciples);
            context.ProjectTechnologgies.RemoveRange(existingProject.ProjectTechnologgies);

            existingProject.Title = request.Title;
            existingProject.CoverImageUrl = request.CoverImageUrl;
            existingProject.Image = request.Image;
            existingProject.Link = request.Link;
            existingProject.Github = request.Github;
            existingProject.UpdatedDate = request.UpdatedDate;

            if (request.ProjectApproachies != null)
            {
                existingProject.ProjectApproaches = request.ProjectApproachies
                    .Select(approach => new ProjectApproachy
                    {
                        ProjectId = existingProject.Id,
                        Key = approach.Key,
                        Value = approach.Value
                    })
                    .ToList();
            }

            if (request.ProjectPrinciples != null)
            {
                existingProject.ProjectPrinciples = request.ProjectPrinciples
                    .Select(principle => new ProjectPrinciple
                    {
                        ProjectId = existingProject.Id,
                        Key = principle.Key,
                        Value = principle.Value
                    })
                    .ToList();
            }

            if (request.ProjectTechnologgies != null)
            {
                existingProject.ProjectTechnologgies = request.ProjectTechnologgies
                    .Select(technologgy => new ProjectTechnologgy
                    {
                        ProjectId = existingProject.Id,
                        Key = technologgy.Key,
                        Value = technologgy.Value
                    })
                    .ToList();
            }
            context.SaveChanges();
            return NoContent();
        }

        [HttpGet("id")]
        public IActionResult Delete(int id)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    var project = context.Projects
                        .Include(a => a.ProjectApproaches)
                        .Include(p => p.ProjectPrinciples)
                        .Include(t => t.ProjectTechnologgies)
                        .FirstOrDefault(p => p.Id == id);

                    if (project == null)
                    {
                        return NotFound();
                    }

                    context.ProjectApproachies.RemoveRange(project.ProjectApproaches);
                    context.ProjectPrinciples.RemoveRange(project.ProjectPrinciples);
                    context.ProjectTechnologgies.RemoveRange(project.ProjectTechnologgies);

                    context.Remove(project);
                    context.SaveChanges();

                    transaction.Commit();

                    return NoContent();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
