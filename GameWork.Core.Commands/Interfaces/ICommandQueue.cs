namespace GameWork.Core.Commands.Interfaces
{
	public interface ICommandQueue : ICommandQueue<ICommand>
	{
	}

	public interface ICommandQueue<TCommand> : ICommandQueueTake<TCommand>, ICommandQueueWrite<TCommand>
		where TCommand : ICommand
	{
        bool HasCommands { get; }
    }
}