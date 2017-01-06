using GameWork.Core.States.Commands.Interfaces;

namespace GameWork.Core.States
{
	public abstract class EventState : State
	{
		private readonly EventStateTransition[] _transitions;

		protected EventState(params EventStateTransition[] stateTransitions)
		{
			_transitions = stateTransitions;
		}

		internal void ConnectTransitions(IChangeStateAction changeStateAction)
		{
			foreach (var transition in _transitions)
			{
				transition.ChangeStateEvent += changeStateAction.ChangeState;
			}
		}

		internal void DisconnectTransisions(IChangeStateAction changeStateAction)
		{
			foreach (var transition in _transitions)
			{
				transition.ChangeStateEvent -= changeStateAction.ChangeState;
			}
		}
	}
}