using Microsoft.EntityFrameworkCore;
using Portfolio.API.Models;

namespace Portfolio.API.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("your connection information");
        }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Skill> Skills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Education>().HasData(getEducationsSeedData());
            modelBuilder.Entity<Experience>().HasData(getExperiencesSeedData());
            modelBuilder.Entity<Project>().HasData(getProjectsSeedData());
            modelBuilder.Entity<Service>().HasData(getServicesSeedData());
            modelBuilder.Entity<Skill>().HasData(getSkillsSeedData());
            modelBuilder.Entity<Setting>().HasData(getSettingSeedData());
        }

        private List<Setting> getSettingSeedData()
        {
            List<Setting> settings = new();
            Setting setting = new()
            {
                Id = 1,
                Name = "Cuma KÖSE",
                Profession = "FullStack .Net Developper Trainer",
                ImageUrl = "profile.png",
                Description = "Description",
                DateOfBirth = Convert.ToDateTime("01.01.1987"),
                Age = 37,
                Website = "https://turkmvc.github.io",
                Linkedin = "https://linkedin.com/in/turkmvc",
                Degree = "CS",
                Country = "Türkiye",
                City = "Elazığ",
                Freelance = "Available",
                CvUrl = "https://www.jobseeker.com/d/3foz0mLM0QP18NuMSkYHDN/view",
                PhoneNumber = "+9555 444 33 22",
                Office = "Elazığ"
            };
            settings.Add(setting);
            return settings;
        }

        private List<Skill> getSkillsSeedData()
        {
            List<Skill> skills = new();
            for (int i = 1; i < 6; i++)
            {
                Skill skill = new()
                {
                    Id = i,
                    Name = "C#",
                    Rating = 76
                };
                skills.Add(skill);
            }
            return skills;
        }

        private List<Service> getServicesSeedData()
        {
            List<Service> services = new();
            for (int i = 1; i <= 6; i++)
            {
                Service service = new()
                {
                    Id = i,
                    Icon = "fa-laptop-code",
                    Name = "FullStack .Net Developper",
                    Description = "Example Description"
                };
                services.Add(service);
            }
            return services;
        }

        private List<Project> getProjectsSeedData()
        {
            List<Project> projects = new();
            for (int i = 1; i <= 6; i++)
            {
                Project project = new()
                {
                    Id = i,
                    Name = "E-Finance",
                    Description = "Example Description",
                    ImageUrl = "project1.png",
                    LiveDemo = "https://turkmvc.github.io",
                    Github = "https://github.com/turkmvc"
                };
                projects.Add(project);
            }
            return projects;
        }

        private List<Experience> getExperiencesSeedData()
        {
            List<Experience> experiences = new();
            for (int i = 1; i <= 6; i++)
            {
                Experience experience = new()
                {
                    Id = i,
                    Name = "Istanbul Education Academy",
                    Description = "Example Description",
                    StartMonth = 09,
                    StartYear = 2023
                };
                experiences.Add(experience);
            }
            return experiences;
        }

        private List<Education> getEducationsSeedData()
        {
            List<Education> educations = new();
            for (int i = 1; i <= 6; i++)
            {
                Education education = new()
                {
                    Id = i,
                    Name = "Istanbul Education Academy",
                    Description = "Example Description",
                    StartMonth = 09,
                    StartYear = 2023
                };
                educations.Add(education);
            }
            return educations;
        }
    }
}
