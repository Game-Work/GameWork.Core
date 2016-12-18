using GameWork.Core.Commands.Interfaces;
using GameWork.Core.States.Commands.Interfaces;

namespace GameWork.Core.States.Commands
{
    public class PreviousStateInSequenceCommand : ICommand<IPreviousStateInSequenceAction>
    {
        public void Execute(IPreviousStateInSequenceAction implementor)
        {
            implementor.PreviousStateInSequence();
        }
    }
}
