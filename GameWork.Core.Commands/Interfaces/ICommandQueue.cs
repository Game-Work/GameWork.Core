namespace GameWork.Core.Commands.Interfaces
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public interface ICommandQueue : ICommandQueue<ICommand>, ICommandQueueTake, ICommandQueueWrite
	{
	}

    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public interface ICommandQueue<TCommand> : ICommandQueueTake<TCommand>, ICommandQueueWrite<TCommand>
		where TCommand : ICommand
	{
        bool HasCommands { get; }
    }
}