namespace GameWork.Core.Commands.Interfaces
{
    public interface ITakeOnlyCommandQueue : ITakeOnlyCommandQueue<ICommand>
    {
    }

    public interface ITakeOnlyCommandQueue<TCommand> : ICommandQueueTake<TCommand>
        where TCommand : ICommand
    {
    }
}
