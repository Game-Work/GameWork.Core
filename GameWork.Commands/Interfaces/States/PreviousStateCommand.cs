using GameWork.Commands.Interfaces;
using GameWork.States;

namespace GameWork.Commands.States
{
    public struct PreviousStateCommand : ICommand
    {
        public void Execute(object parameter)
        {
            var castParameter = (SequenceState)parameter;
            castParameter.PreviousState();
        }
    }
}
