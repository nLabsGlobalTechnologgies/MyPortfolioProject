namespace Portfolio.API.Models
{
    public sealed class Setting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Website { get; set; }
        public string Linkedin { get; set; }
        public string Degree { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Freelance { get; set; }
        public string CvUrl { get; set; }
        public string PhoneNumber { get; set; }
        public string Office { get; set; }
        public DateTime CreatedDate { get; private set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
    }
}
