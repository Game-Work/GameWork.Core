using GameWork.States.Interfaces;

namespace GameWork.States
{
    public abstract class TickableState : State, ITickableState
    {
        public abstract void Tick(float deltaTime);
    }
}