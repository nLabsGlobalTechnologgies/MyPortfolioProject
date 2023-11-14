namespace Server.DTOs.Property
{
    public sealed record AddPropertyDto(
        string Name,
        string Key,
        string Value
    );
}
