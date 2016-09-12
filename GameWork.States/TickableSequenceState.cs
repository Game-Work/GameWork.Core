using GameWork.States.Interfaces;

namespace GameWork.States
{
    public abstract class TickableSequenceState : SequenceState, ITickableState
    {
        public abstract void Tick(float deltaTime);
    }
}
