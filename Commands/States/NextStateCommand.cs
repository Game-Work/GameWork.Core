using GameWork.Commands.Interfaces;
using GameWork.States;

namespace GameWork.Commands.States
{
    public struct NextStateCommand : ICommand
    {
        public void Execute(object parameter)
        {
            var castParameter = (SequenceState)parameter;
            castParameter.NextState();
        }
    }
}
