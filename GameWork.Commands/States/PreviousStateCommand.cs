using GameWork.Commands.Interfaces;
using GameWork.Commands.States.Interfaces;

namespace GameWork.Commands.States
{
    public struct PreviousStateCommand : ICommand<IPreviousStateAction>
    {
        public void Execute(IPreviousStateAction implementor)
        {
            implementor.PreviousState();
        }
    }
}
