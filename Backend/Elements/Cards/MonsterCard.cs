using FMD.Backend.Enums;

namespace FMD.Backend.Elements.Cards;

public class MonsterCard : Card
{
    public int Attack { get; set; }
    public int Energy { get; set; }
    public bool AttackThisTurn { get; set; }
    public MonsterType MonsterType { get; set; }
    public Element Element { get; set; }
}