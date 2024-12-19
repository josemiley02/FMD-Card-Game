using FMD.Backend.Elements.Effects;
using FMD.Backend.Elements.Players;
using FMD.Backend.Interfaces;

namespace FMD.Backend.Elements.Cards;

public abstract class Card : Entity
{
    public int Cost { get; set; }
    public bool IsOnTheField { get; set; }
    public int OwnerId { get; set; }
    public Player Owner { get; set; } = null!;
    public ICollection<Effect> Effects { get; set; } = new List<Effect>();
}