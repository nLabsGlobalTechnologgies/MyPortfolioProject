namespace Portfolio.API.DTOs
{
    public sealed record UpdateSkillDto(
        int Id,
        string Name,
        int Rating,
        DateTime? UpdatedDate
    );
}
