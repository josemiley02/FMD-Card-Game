namespace FMD
{
    public class DrawCrad : Effect
    {
        public int Cant {get; set;}
        public DrawCrad(int cant)
        {
            this.Cant = cant;
            Description = "Draw " + cant + " cards of your deck";
        }
        public override void Activate()
        {
            throw new NotImplementedException();
        }
    }
}