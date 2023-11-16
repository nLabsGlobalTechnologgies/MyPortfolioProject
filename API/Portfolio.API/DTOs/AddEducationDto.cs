namespace Portfolio.API.DTOs
{
    public sealed record AddEducationDto(
        string Name,
        string Description,
        int StartMonth,
        int StartYear,
        int? EndMonth,
        int? EndYear
    );
}
