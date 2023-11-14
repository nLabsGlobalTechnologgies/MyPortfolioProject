using Server.Models;

namespace Server.Models
{
    public sealed class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? CoverImageUrl { get; set; }
        public string? Image { get; set; }
        public string? Link { get; set; }
        public string? Github { get; set; }
        public List<ProjectApproachy> ProjectApproaches { get; set; } = new List<ProjectApproachy>();
        public List<ProjectPrinciple> ProjectPrinciples { get; set; } = new List<ProjectPrinciple>();
        public List<ProjectTechnologgy> ProjectTechnologgies { get; set; } = new List<ProjectTechnologgy>();
        public DateTime CreatedDate { get; private set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
    }
}