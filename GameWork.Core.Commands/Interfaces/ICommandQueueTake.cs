using System.Collections.Generic;

namespace GameWork.Core.Commands.Interfaces
{
    public interface ICommandQueueTake : ICommandQueueTake<ICommand>
    {
    }

    public interface ICommandQueueTake<TCommand>
        where TCommand : ICommand
    {
        bool TryTakeFirstCommand(out TCommand command);

        bool TryTakeAllCommands(out IList<TCommand> commands);

        TCommand TakeFirstCommand();

        IList<TCommand> TakeAllCommands();
    }
}