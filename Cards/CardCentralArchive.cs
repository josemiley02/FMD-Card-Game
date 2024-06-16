namespace FMD
{
    public static class CardCentralArchive
    {
        public static List<Card> Cards = new List<Card>();
        public static void GetCards()
        {
            Cards.Add(new Card("Insect Devil", 1500, 1, 2, Cards.Count, new ChangeAtk(-1000)));
            Cards.Add(new Card("Dark Witch", 2000, 2, 2, Cards.Count, new ChangeLife(2)));
            Cards.Add(new Card("Pot Own", 1200, 2, 3, Cards.Count, new DrawCrad(2)));
        }
    }
}