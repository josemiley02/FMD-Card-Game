using FMD;
using System.Text;
namespace Application
{
    public static class Engine
    {
        public static void GetDeck(Player player)
        {
            var cca = CardCentralArchive.Cards;
            int[] cards = new int[cca.Count];
            int select = 0;
            {
                ConsoleKeyInfo keyInfo;
                StringBuilder sb = new StringBuilder();
                do
                {
                    keyInfo = Console.ReadKey(true);

                    if (char.IsDigit(keyInfo.KeyChar))
                    {
                        sb.Append(keyInfo.KeyChar);
                        Console.Write(keyInfo.KeyChar);
                    }
                    else if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        select = int.Parse(sb.ToString());
                        cards[select]++;

                        if (cards[select] > 4) continue;
                        player.Deck.Push(cca[select]);
                        sb.Clear();
                    }
                }
                while (player.Deck.Count < 25);
            }
        }
    }
}