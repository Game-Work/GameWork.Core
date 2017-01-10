using System.Collections.Generic;
using GameWork.Core.States.Commands.Interfaces;

namespace GameWork.Core.States.Event
{
	public abstract class EventState : State
	{
		private readonly List<EventStateTransition> _transitions = new List<EventStateTransition>();

		public void AddTransitions(params EventStateTransition[] stateTransitions)
		{
			_transitions.AddRange(stateTransitions);
		}

		internal void ConnectTransitions(IChangeStateAction changeStateAction)
		{
			foreach (var transition in _transitions)
			{
				transition.ChangeStateEvent += changeStateAction.ChangeState;
				transition.Enter();
			}
		}

		internal void DisconnectTransisions(IChangeStateAction changeStateAction)
		{
			foreach (var transition in _transitions)
			{
				transition.Exit();
				transition.ChangeStateEvent -= changeStateAction.ChangeState;
			}
		}
	}
}