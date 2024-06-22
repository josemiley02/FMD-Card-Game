namespace FMD
{
    public class Game
    {
        public Game()
        {
            Map = new Card[4,3];
            PlayerEngine.IniatilizatePlayers(player1!, player2!);
        }
        public Card[,] Map { get; private set; }
        public Player? player1 {get; private set;}
        public Player? player2 {get; private set;}
    }
}