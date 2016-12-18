using GameWork.Core.Commands.Interfaces;
using GameWork.Core.States.Commands.Interfaces;

namespace GameWork.Core.States.Commands
{
    public class TryPreviousStateInHistoryCommand : ICommand<ITryPreviousStateInHistoryAction>
    {
        public void Execute(ITryPreviousStateInHistoryAction implementor)
        {
            implementor.TryPreviousStateInHistory();
        }
    }
}
