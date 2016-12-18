using GameWork.Core.Commands.Interfaces;

namespace GameWork.Core.States.Commands.Interfaces
{
    public interface ITryNextStateInHistoryAction : ICommandAction
    {
        bool TryNextStateInHistory();
    }
}
