using Server.DTOs.Project.ProjectApproachy;
using Server.DTOs.Project.ProjectPrinciple;
using Server.DTOs.Project.ProjectTechnologgy;

namespace Server.DTOs.Project
{
    public sealed record UpdateProjectDto(
        int Id,
        string Title,
        string? CoverImageUrl,
        string? Image,
        string? Link,
        string? Github,
        DateTime? UpdatedDate,
        List<UpdateProjectApproachyDto>? ProjectApproachies,
        List<UpdateProjectPrincipleDto>? ProjectPrinciples,
        List<UpdateProjectTechnologgyDto>? ProjectTechnologgies
    );
}
