using GameWork.Core.Commands;
using GameWork.Core.Commands.Interfaces;
using GameWork.Core.States.Commands;

namespace GameWork.Core.States.Tests.TestObjects
{
	public class TestStateCommandResolver : CommandResolver
	{
		private readonly TickStateController _stateController;

		public TestStateCommandResolver(TickStateController stateController)
		{
			_stateController = stateController;
		}

		public override void ProcessCommand(ICommand command)
		{
			var changeStateCommand = command as ChangeStateCommand;
			if (changeStateCommand != null)
			{
				changeStateCommand.Execute(_stateController);
				return;
			}

			var nextStateInSequenceCommand = command as NextStateInSequenceCommand;
			if (nextStateInSequenceCommand != null)
			{
                nextStateInSequenceCommand.Execute(_stateController);
				return;
			}

			var previousStateInSequenceCommand = command as PreviousStateInSequenceCommand;
			if (previousStateInSequenceCommand != null)
			{
                previousStateInSequenceCommand.Execute(_stateController);
				return;
			}

            var tryPreviousStateInHistoryCommand = command as TryPreviousStateInHistoryCommand;
            if (tryPreviousStateInHistoryCommand != null)
            {
                tryPreviousStateInHistoryCommand.Execute(_stateController);
                return;
            }

            var tryNextStateInHistoryCommand = command as TryNextStateInHistoryCommand;
            if (tryNextStateInHistoryCommand != null)
            {
                tryNextStateInHistoryCommand.Execute(_stateController);
                return;
            }
        }
	}
}
