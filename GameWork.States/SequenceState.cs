using GameWork.Commands.States.Interfaces;

namespace GameWork.States
{
    public abstract class SequenceState : State, INextStateAction, IPreviousStateAction
    {
        public abstract void NextState();

        public abstract void PreviousState();
    }
}
