namespace Portfolio.API.DTOs
{
    public sealed record UpdatePortfolioDto(
        int Id,
        string Name,
        string ImageUrl,
        string? LiveDemo,
        string? Github,
        string? Description,
        DateTime? UpdatedDate
    );
}
