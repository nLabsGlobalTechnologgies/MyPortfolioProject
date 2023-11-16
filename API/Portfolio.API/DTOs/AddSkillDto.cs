namespace Portfolio.API.DTOs
{
    public sealed record AddSkillDto(
        string Name,
        int Rating
    );
}
