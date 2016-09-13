using GameWork.Commands.Interfaces;

namespace GameWork.Commands.States.Interfaces
{
    public interface IChangeStateAction : ICommandAction
    {
        void ChangeState(string toStateName);
    }
}
