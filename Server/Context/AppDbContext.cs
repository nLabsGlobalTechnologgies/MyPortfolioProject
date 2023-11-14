using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SERVER;Initial Catalog=IEAPortfolioDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<ProjectApproachy> ProjectApproachies { get; set; }
        public DbSet<ProjectPrinciple> ProjectPrinciples { get; set; }
        public DbSet<ProjectTechnologgy> ProjectTechnologgies { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}
