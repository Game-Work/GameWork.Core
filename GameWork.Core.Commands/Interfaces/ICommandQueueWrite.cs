using System.Collections.Generic;

namespace GameWork.Core.Commands.Interfaces
{
    public interface ICommandQueueWrite : ICommandQueueWrite<ICommand>
    {
    }

    public interface ICommandQueueWrite<TCommand>
        where TCommand : ICommand
    {
        void AddCommand(TCommand command);

        void AddCommands(IEnumerable<TCommand> commands);
    }
}
