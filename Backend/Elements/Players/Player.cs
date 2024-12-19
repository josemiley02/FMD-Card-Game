using FMD.Backend.Elements.Cards;
using FMD.Backend.Interfaces;

namespace FMD.Backend.Elements.Players;

public class Player : Entity
{
    public int Manna { get; set; }
    public int Life { get; set; }
    public int OponentId { get; set; }
    public bool InvokeThisTurn { get; set; }
    public Player Opponent { get; set; } = null!;
    public Stack<Card> Deck { get; set; } = new Stack<Card>();
    public List<Card> Hand { get; set; } = new List<Card>();

    public void Draw(int count)
    {
        while (count > 0)
        {
            Hand.Add(Deck.Pop());
        }
    }
    public void Sacrifice(MonsterCard card)
    {
        Manna += card.Energy;
    }
}