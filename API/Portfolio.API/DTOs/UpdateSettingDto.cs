namespace Portfolio.API.DTOs
{
    public sealed record UpdateSettingDto(
        int Id,
        string Name,
        string Description,
        DateTime DateOfBirth,
        int Age,
        string Website,
        string Linkedin,
        string Degree,
        string Country,
        string City,
        string Freelance,
        string CvUrl,
        string PhoneNumber,
        string Office,
        DateTime? UpdatedDate
    );
}
