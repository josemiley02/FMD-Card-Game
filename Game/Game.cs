namespace FMD
{
    public class Game
    {
        public Game()
        {
            Map = new Card[4,3];
            Mask = new bool[4,3];
        }
        public Card[,] Map { get; private set; }
        public bool[,] Mask { get; private set; }
    }
}