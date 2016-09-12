namespace GameWork.States
{
    public abstract class TickableState : State
    {
        public abstract void Tick(float deltaTime);
    }
}