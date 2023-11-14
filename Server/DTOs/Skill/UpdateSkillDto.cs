namespace Server.DTOs.Skill
{
    public sealed record UpdateSkillDto(
        int Id,
        string Title,
        string? Description,
        byte? Rating,
        DateTime? UpdatedDate
    );
}
