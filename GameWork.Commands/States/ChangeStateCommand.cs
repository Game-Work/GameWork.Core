using GameWork.Commands.Interfaces;
using GameWork.Commands.States.Interfaces;

namespace GameWork.Commands.States
{
    public class ChangeStateCommand : ICommand<IChangeStateAction>
    {
        private readonly string _toStateName;

        public ChangeStateCommand(string toStateName)
        {
            _toStateName = toStateName;
        }

        public void Execute(IChangeStateAction parameter)
        {
            parameter.ChangeState(_toStateName);
        }
    }
}
