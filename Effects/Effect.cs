namespace FMD
{
    public abstract class Effect
    {
        public bool IsActivateThisTurn {get; private set;}
        public void ChangeState()
        {
            IsActivateThisTurn = !IsActivateThisTurn;
        }
        public abstract void Activate();
    }
}