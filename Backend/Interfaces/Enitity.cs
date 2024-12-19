namespace FMD.Backend.Interfaces;

public class Entity : IEntity
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
}