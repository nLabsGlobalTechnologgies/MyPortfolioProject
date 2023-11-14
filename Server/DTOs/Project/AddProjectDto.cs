using Server.DTOs.Project.ProjectApproachy;
using Server.DTOs.Project.ProjectPrinciple;
using Server.DTOs.Project.ProjectTechnologgy;

namespace Server.DTOs.Project
{
    public sealed record AddProjectDto(
        string Title,
        string? CoverImageUrl,
        string? Image,
        string? Link,
        string? Github,
        List<AddProjectApproachyDto>? ProjectApproaches,
        List<AddProjectPrincipleDto>? ProjectPrinciples,
        List<AddProjectTechnologgyDto>? ProjectTechnologgies
    );
}
