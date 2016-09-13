using GameWork.Commands.Interfaces;
using GameWork.Commands.States.Interfaces;

namespace GameWork.Commands.States
{
    public struct NextStateCommand : ICommand<INextStateAction>
    {
        public void Execute(INextStateAction implementor)
        {
            implementor.NextState();
        }
    }
}
