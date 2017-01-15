using System;

namespace GameWork.Core.States.Event
{
	public abstract class EventStateTransition
	{
		internal event Action<string> EnterStateEvent;
		internal event Action<string> ExitStateEvent;

		protected virtual void OnEnter(string fromStateName)
		{
		}

		protected virtual void OnExit(string toStateName)
		{
		}

		protected virtual void EnterState(string toStateName)
		{
			EnterStateEvent(toStateName);
		}

		protected virtual void ExitState(string toStateName)
		{
			ExitStateEvent(toStateName);
		}

		internal virtual void Enter(string fromStateName)
		{
			OnEnter(fromStateName);
		}

		internal virtual void Exit(string toStateName)
		{
			OnExit(toStateName);
		}
	}
}
