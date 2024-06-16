using System.Text;

namespace FMD
{
    public class Player
    {
        public Player(string name, int id)
        {
            Name = name;
            ID = id;
            Manna = 5;
            Life = 6;
            Deck = [];
            Hand = [];
        }

        public string Name { get; set; }
        public int Life { get; set; }
        public int Manna { get; set; }
        public int ID { get; set; }
        public Stack<Card> Deck { get; set; }
        public List<Card> Hand { get; set; }

        public void GetDeck()
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
                        
                        if(cards[select] > 4) continue;
                        Deck.Push(cca[select]);
                        sb.Clear();
                    }
                }
                while (Deck.Count < 25);
            }
        }
    }
}