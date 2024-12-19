using FMD.Backend.Enums;

namespace FMD.Backend.Elements.Cards;

public class MonsterCard : Card
{
    public int Attack { get; set; }
    private int _attack { get; set; }
    public int Energy { get; set; }
    private int _energy { get; set; }
    public bool AttackThisTurn { get; set; }
    public MonsterType MonsterType { get; set; }
    private MonsterType _monsterType { get; set; }
    public Element Element { get; set; }
    private Element _element { get; set; } 

    public MonsterCard()
    {
        _attack = Attack;
        _energy = Energy;
        _monsterType = MonsterType;
        _element = Element;
    }
    public override void SetOrigin()
    {
        Attack = _attack;
        Energy = _energy;
        MonsterType = _monsterType;
        Element = _element;
    }
    public void BattleWithOtherCard(MonsterCard card)
    {
        var aux = card.Attack;
        card.Attack -= Attack;
        Attack -= aux;
    }
}