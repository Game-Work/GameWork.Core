using GameWork.Core.Commands.Interfaces;
using GameWork.Core.States.Commands.Interfaces;

namespace GameWork.Core.States.Commands
{
    public class NextStateInSequenceCommand : ICommand<INextStateInSequenceAction>
    {
        public void Execute(INextStateInSequenceAction implementor)
        {
            implementor.NextStateInSequence();
        }
    }
}
