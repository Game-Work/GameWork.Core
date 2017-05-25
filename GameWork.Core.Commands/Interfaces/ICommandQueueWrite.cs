using System.Collections.Generic;

namespace GameWork.Core.Commands.Interfaces
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public interface ICommandQueueWrite : ICommandQueueWrite<ICommand>
    {
    }

    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public interface ICommandQueueWrite<TCommand>
        where TCommand : ICommand
    {
        void AddCommand(TCommand command);

        void AddCommands(IEnumerable<TCommand> commands);
    }
}
