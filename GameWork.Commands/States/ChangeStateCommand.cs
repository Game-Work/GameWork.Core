using GameWork.Commands.Interfaces;
using GameWork.Commands.States.Interfaces;

namespace GameWork.Commands.States
{
    public struct ChangeStateCommand : ICommand
    {
        private readonly string _toStateName;

        public ChangeStateCommand(string toStateName)
        {
            _toStateName = toStateName;
        }

        public void Execute(object parameter)
        {
            var castParameter = (IChangeStateAction)parameter;
            castParameter.ChangeState(_toStateName);
        }
    }
}
