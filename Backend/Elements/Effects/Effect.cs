using FMD.Backend.Elements.Games;
using FMD.Backend.Enums;
using FMD.Backend.Interfaces;

namespace FMD.Backend.Elements.Effects;

public abstract class Effect : Entity
{
    public string Description { get; set; } = string.Empty;
    public EffectType EffectType { get; set; } = EffectType.None;
    public abstract void Activate(Game game);
}