using GameWork.Core.Commands.Interfaces;

namespace GameWork.Core.States.Commands.Interfaces
{
    public interface IPreviousStateInSequenceAction : ICommandAction
    {
        void PreviousStateInSequence();
    }
}
