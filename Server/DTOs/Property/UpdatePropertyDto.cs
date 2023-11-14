namespace Server.DTOs.Property
{
    public sealed record UpdatePropertyDto(
        int Id,
        string Name,
        string Key,
        string Value,
        DateTime? UpdatedDate
    );
}
