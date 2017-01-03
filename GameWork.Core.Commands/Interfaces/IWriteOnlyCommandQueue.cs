namespace GameWork.Core.Commands.Interfaces
{
    public interface IWriteOnlyCommandQueue : IWriteOnlyCommandQueue<ICommand>
    {
    }

    public interface IWriteOnlyCommandQueue<TCommand> : ICommandQueueWrite<TCommand>
        where TCommand : ICommand
    {
    }
}
