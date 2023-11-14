using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("your connection information data context info");
        }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<ProjectApproachy> ProjectApproachies { get; set; }
        public DbSet<ProjectPrinciple> ProjectPrinciples { get; set; }
        public DbSet<ProjectTechnologgy> ProjectTechnologgies { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}
