namespace Portfolio.API.DTOs
{
    public sealed record AddServiceDto(
        string  Icon,
        string Name,
        string Description
    );
}
