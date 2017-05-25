using System.Collections.Generic;

namespace GameWork.Core.States.Event
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public abstract class EventState : State
	{
		private readonly List<EventStateTransition> _transitions = new List<EventStateTransition>();

		public void AddTransitions(params EventStateTransition[] stateTransitions)
		{
			_transitions.AddRange(stateTransitions);
		}

		internal override void Enter(string fromStateName)
		{
			base.Enter(fromStateName);
			_transitions.ForEach(t => t.Enter(fromStateName));
		}

		internal override void Exit(string toStateName)
		{
			_transitions.ForEach(t => t.Exit(toStateName));
			base.Exit(toStateName);
		}

		internal void ConnectTransitions(StateControllerBase stateController)
		{
			foreach (var transition in _transitions)
			{
				transition.ExitStateEvent += stateController.ExitState;
				transition.EnterStateEvent += stateController.EnterState;
			}
		}

		internal void DisconnectTransisions(StateControllerBase stateController)
		{
			foreach (var transition in _transitions)
			{
				transition.ExitStateEvent -= stateController.ExitState;
				transition.EnterStateEvent -= stateController.EnterState;
			}
		}
	}
}