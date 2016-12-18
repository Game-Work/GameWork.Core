using GameWork.Core.Commands.Interfaces;

namespace GameWork.Core.States.Commands.Interfaces
{
    public interface ITryPreviousStateInHistoryAction : ICommandAction
    {
        bool TryPreviousStateInHistory();
    }
}
