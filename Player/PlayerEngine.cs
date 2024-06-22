using System.Text;
using Application;

namespace FMD
{
    public static class PlayerEngine
    {
        public static void IniatilizatePlayers(Player player1, Player player2)
        {
            player1 = CreatePlayer(1);
            player2 = CreatePlayer(2);
            GetDeck(player1);
            GetDeck(player2);
        }
        public static Player CreatePlayer(int id)
        {
            string name = "";
            while (name == "")
            {
                name = Console.ReadLine()!;
            }
            return new Player(name, id);
        }
        public static void GetDeck(Player player)
        {
            //Cuando se cambie de interfaz grafica se actualiza esta version del metodo
            Engine.GetDeck(player);
        }
    }
}