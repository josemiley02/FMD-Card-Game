namespace FMD
{
    public class ChangeLife : Effect
    {
        public int Modification { get; set; }
        public ChangeLife(int modification)
        {
            Modification = modification;
            if (Modification < 0)
            {
                Description = "Decrease the life of your opponent by: " + -modification;
            }
            else Description = "Increase your life by: " + modification;
        }

        public override void Activate()
        {
            throw new NotImplementedException();
        }
    }
}