using GameWork.Core.States.Commands.Interfaces;

namespace GameWork.Core.States.Interfaces
{
	public interface IStateController : IChangeStateAction, INextStateInSequenceAction, 
		IPreviousStateInSequenceAction, ITryNextStateInHistoryAction, ITryPreviousStateInHistoryAction
	{
		int ActiveStateIndex { get; }

		int ActiveStateHistoryIndex { get; }

		string ActiveStateName { get; }

		int HistoryCount { get; }

		void Initialize();

		void Terminate();
	}
}
