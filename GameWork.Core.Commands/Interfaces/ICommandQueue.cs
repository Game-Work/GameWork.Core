namespace GameWork.Core.Commands.Interfaces
{
	public interface ICommandQueue : ICommandQueue<ICommand>, ICommandQueueTake, ICommandQueueWrite
	{
	}

	public interface ICommandQueue<TCommand> : ICommandQueueTake<TCommand>, ICommandQueueWrite<TCommand>
		where TCommand : ICommand
	{
        bool HasCommands { get; }
    }
}