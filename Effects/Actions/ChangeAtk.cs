namespace FMD
{
    public class ChangeAtk : Effect
    {
        private int Modification;

        public ChangeAtk(int modification)
        {
            Modification = modification;
            Description = "Select a card in the field then ";
            if (modification < 0)
            {
                Description += "decrease its attack by " + -modification;
            }
            else Description += "increase its attack by " + modification;
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