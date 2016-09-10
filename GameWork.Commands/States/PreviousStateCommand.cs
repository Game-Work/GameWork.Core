using GameWork.Commands.Interfaces;
using GameWork.Commands.States.Interfaces;

namespace GameWork.Commands.States
{
    public struct PreviousStateCommand : ICommand
    {
        public void Execute(object parameter)
        {
            var castParameter = (IPreviousStateAction)parameter;
            castParameter.PreviousState();
        }
    }
}
