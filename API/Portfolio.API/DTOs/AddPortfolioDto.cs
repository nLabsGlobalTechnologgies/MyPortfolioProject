namespace Portfolio.API.DTOs
{
    public sealed record AddPortfolioDto(
        string Name,
        string ImageUrl,
        string? LiveDemo,
        string? Github,
        string? Description
    );
}
