using GameWork.Core.States.Commands.Interfaces;

namespace GameWork.Core.States.Event
{
	public abstract class EventState : State
	{
		private EventStateTransition[] _transitions;

		public void AddTransitions(params EventStateTransition[] stateTransitions)
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