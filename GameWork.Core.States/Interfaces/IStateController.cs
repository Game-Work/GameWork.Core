using GameWork.Core.Interfaces;
using GameWork.Core.States.Commands.Interfaces;

namespace GameWork.Core.States.Interfaces
{
	public interface IStateController : IInitializable,
		IChangeStateAction, INextStateInSequenceAction, IPreviousStateInSequenceAction, ITryNextStateInHistoryAction,
		ITryPreviousStateInHistoryAction
	{
		int ActiveStateIndex { get; }

		int ActiveStateHistoryIndex { get; }

		string ActiveStateName { get; }

		int HistoryCount { get; }
	}
}
