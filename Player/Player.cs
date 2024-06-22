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

        public override string ToString()
        {
            return nameof(Player) + " " + ID + ": " + Name;
        }
    }
}