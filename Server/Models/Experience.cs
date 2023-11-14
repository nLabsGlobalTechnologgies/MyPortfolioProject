namespace Server.Models
{
    public sealed class Experience
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public int StartMonth { get; set; }
        public int StartYear { get; set; }
        public int? EndMonth { get; set; }
        public int? EndYear { get; set; }
        public DateTime CreatedDate { get; private set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }

    }
}
