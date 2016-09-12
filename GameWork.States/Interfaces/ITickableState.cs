namespace GameWork.States.Interfaces
{
    public interface ITickableState : IState
    {
        void Tick(float deltaTime);
    }
}