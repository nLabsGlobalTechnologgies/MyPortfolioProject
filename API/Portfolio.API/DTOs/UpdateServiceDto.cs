namespace Portfolio.API.DTOs
{
    public sealed record UpdateServiceDto(
        int Id,
        string Icon,
        string Name,
        string Description,
        DateTime? UpdatedDate
    );
}
