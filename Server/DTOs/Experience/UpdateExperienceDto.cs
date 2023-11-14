namespace Server.DTOs.Experience
{
    public sealed record UpdateExperienceDto(
        int Id,
        string Type,
        string Title,
        string? Description,
        int StartMonth,
        int StartYear,
        int? EndMonth,
        int? EndYear,
        DateTime? UpdatedDate
    );
}
