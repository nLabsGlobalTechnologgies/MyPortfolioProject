namespace Server.Models
{
    public sealed class Skill
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte? Rating { get; set; }
        public DateTime CreatedDate { get; private set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
    }
}
