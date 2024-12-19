namespace FMD.Backend.Interfaces;

public class Enitity : IEntity
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
}