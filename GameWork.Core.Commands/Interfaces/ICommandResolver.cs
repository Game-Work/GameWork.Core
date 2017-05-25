using System.Collections.Generic;

namespace GameWork.Core.Commands.Interfaces
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public interface ICommandResolver : ICommandResolver<ICommand>
	{
	}

    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public interface ICommandResolver<TCommand>
		where TCommand : ICommand
	{
		void ProcessCommand(TCommand command);

		void ProcessCommands(IEnumerable<TCommand> commmands);
	}
}
