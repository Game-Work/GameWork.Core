using GameWork.Commands.Interfaces;

namespace GameWork.Commands.States.Interfaces
{
    public interface INextStateAction : ICommandAction
    {
        void NextState();
    }
}
