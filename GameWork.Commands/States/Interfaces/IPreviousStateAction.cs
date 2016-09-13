using GameWork.Commands.Interfaces;

namespace GameWork.Commands.States.Interfaces
{
    public interface IPreviousStateAction : ICommandAction
    {
        void PreviousState();
    }
}
