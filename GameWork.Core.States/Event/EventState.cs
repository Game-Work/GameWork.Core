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
			_transitions.ForEach(t => t.ChangeStateEvent += changeStateAction.ChangeState);
		}

		internal void DisconnectTransisions(IChangeStateAction changeStateAction)
		{
			_transitions.ForEach(t => t.ChangeStateEvent -= changeStateAction.ChangeState);
		}
	}
}