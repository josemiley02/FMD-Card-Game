using FMD.Backend.Elements.Cards;
using FMD.Backend.Elements.Games;

namespace FMD.Backend.Rules;

public static class GameRules
{
    private static int CheckCondition(Game game, long row, Func<Card, bool> predicate)
    {
        var table = game.Table;
        for (int i = 0; i < table.GetLength(1); i++)
        {
            if(predicate(table[row, i])) return i;
        }
        return -1;
    }
    public static bool CanInvoke(Game game, Card card, out int pos)
    {
        var player = game.CurrentPlayer;
        pos = CheckCondition(game, player.Id, c => !c.IsOnTheField);
        return pos >= 0 && card.Cost <= player.Manna;
    }
}