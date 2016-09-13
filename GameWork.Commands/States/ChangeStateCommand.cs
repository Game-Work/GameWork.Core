using GameWork.Commands.Interfaces;
using GameWork.Commands.States.Interfaces;

namespace GameWork.Commands.States
{
    public struct ChangeStateCommand : ICommand<IChangeStateAction>
    {
        private readonly string _toStateName;

        public ChangeStateCommand(string toStateName)
        {
            _toStateName = toStateName;
        }

        public void Execute(IChangeStateAction implementor)
        {
            implementor.ChangeState(_toStateName);
        }
    }
}
