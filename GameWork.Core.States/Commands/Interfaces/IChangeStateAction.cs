using GameWork.Core.Commands.Interfaces;

namespace GameWork.Core.States.Commands.Interfaces
{
    public interface IChangeStateAction : ICommandAction
    {
        void ChangeState(string toStateName);
    }
}
