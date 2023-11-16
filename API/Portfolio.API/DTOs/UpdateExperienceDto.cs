namespace Portfolio.API.DTOs
{
    public sealed record UpdateExperienceDto(
        int Id,
        string Name,
        string Description,
        int StartMonth,
        int StartYear,
        int? EndMonth,
        int? EndYear,
        DateTime? UpdatedDate
    );
}
