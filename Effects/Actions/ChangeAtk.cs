namespace FMD
{
    public class ChangeAtk : Effect
    {
        private int Modification;
        public ChangeAtk(int modification)
        {
            Modification = modification;
        }

        public override void Activate()
        {
            throw new NotImplementedException();
        }
        private void Activate(Card card)
        {
            card.ATK += Modification;
        }
    }
}