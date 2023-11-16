namespace Portfolio.API.Models
{
    public sealed class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public string? LiveDemo { get; set; }
        public string? Github { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; private set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
    }
}
