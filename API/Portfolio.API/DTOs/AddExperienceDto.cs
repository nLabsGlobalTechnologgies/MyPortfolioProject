namespace Portfolio.WebAPI.DTOs
{
    public sealed record AddExperienceDto(
        string Name,
        string Description,
        int StartMonth,
        int StartYear,
        int? EndMonth,
        int? EndYear
    );
}
