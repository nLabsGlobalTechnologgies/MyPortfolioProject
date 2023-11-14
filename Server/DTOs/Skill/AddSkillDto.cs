namespace Server.DTOs.Skill
{
    public sealed record AddSkillDto(
        string Title,
        string? Description,
        byte? Rating
     );
}
