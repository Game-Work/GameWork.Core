using GameWork.Commands.Interfaces;
using GameWork.Commands.States.Interfaces;

namespace GameWork.Commands.States
{
    public struct NextStateCommand : ICommand
    {
        public void Execute(object parameter)
        {
            var castParameter = (INextStateAction)parameter;
            castParameter.NextState();
        }
    }
}
