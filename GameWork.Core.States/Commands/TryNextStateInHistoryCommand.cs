using GameWork.Core.Commands.Interfaces;
using GameWork.Core.States.Commands.Interfaces;

namespace GameWork.Core.States.Commands
{
    public class TryNextStateInHistoryCommand : ICommand<ITryNextStateInHistoryAction>
    {
        public void Execute(ITryNextStateInHistoryAction implementor)
        {
            implementor.TryNextStateInHistory();
        }
    }
}
