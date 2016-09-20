using System.Collections.Generic;
using GameWork.Commands.Interfaces;

namespace GameWork.Commands
{
	public abstract class CommandResolver : CommandResolver<ICommand>
	{
	}

	public abstract class CommandResolver<TCommand> : ICommandResolver<TCommand>
		where TCommand : ICommand
	{
		public abstract void ProcessCommand(TCommand command);

		public void ProcessCommands(IEnumerable<TCommand> commands)
		{
			foreach (var command in commands)
			{
				ProcessCommand(command);
			}
		}
	}
}
