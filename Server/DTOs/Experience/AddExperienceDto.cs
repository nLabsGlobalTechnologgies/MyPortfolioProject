namespace Server.DTOs.Experience
{
    public sealed record AddExperienceDto(
        string Type,
        string Title,
        string? Description,
        int StartMonth,
        int StartYear,
        int? EndMonth,
        int? EndYear
    );
}
