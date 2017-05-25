using System.Collections.Generic;

namespace GameWork.Core.Commands.Interfaces
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public interface ICommandQueueTake : ICommandQueueTake<ICommand>
    {
    }

    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public interface ICommandQueueTake<TCommand>
        where TCommand : ICommand
    {
        bool TryTakeFirstCommand(out TCommand command);

        bool TryTakeAllCommands(out IList<TCommand> commands);

        TCommand TakeFirstCommand();

        IList<TCommand> TakeAllCommands();
    }
}