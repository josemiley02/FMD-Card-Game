using FMD.Backend.Elements.Cards;
using FMD.Backend.Elements.Players;
using FMD.Backend.Enums;

namespace FMD.Backend.Elements.Games;

public class Game
{
    public Player CurrentPlayer { get; set; } = null!;
    public Player OpponentPlayer { get; set; } = null!;
    public Card[,] Table { get; set; } = new Card[4, 3]; // 4 rows, 3 columns
    public List<Card> Graveyard { get; set; } = new List<Card>();
    public GameAction CurrentAction { get; set; }

    public void ChangeTurn()
    {
        var aux = CurrentPlayer;
        CurrentPlayer = OpponentPlayer;
        OpponentPlayer = aux;
        PlayTurn();
    }
    public void PlayTurn()
    {
        
    }
}