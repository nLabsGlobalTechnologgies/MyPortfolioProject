namespace Server.Models
{
    public sealed class ProjectPrinciple
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime CreatedDate { get; private set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
    }
}
