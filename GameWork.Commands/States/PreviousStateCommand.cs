using GameWork.Commands.Interfaces;
using GameWork.Commands.States.Interfaces;

namespace GameWork.Commands.States
{
    public class PreviousStateCommand : ICommand<IPreviousStateAction>
    {
        public void Execute(IPreviousStateAction parameter)
        {
            parameter.PreviousState();
        }
    }
}
