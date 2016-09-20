using GameWork.States.Interfaces;

namespace GameWork.States
{
    public abstract class SequenceState : State, ISequenceState
    {
        public abstract void NextState();

        public abstract void PreviousState();
    }
}
