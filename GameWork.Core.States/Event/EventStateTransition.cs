using System;

namespace GameWork.Core.States.Event
{
	public abstract class EventStateTransition
	{
		internal event Action<string> ChangeStateEvent;
		
		protected virtual void OnEnter(string fromStateName)
		{
		}

		protected virtual void OnExit(string toStateName)
		{
		}

		protected void ChangeState(string toStateName)
		{
			ChangeStateEvent(toStateName);
		}

		internal void Enter(string fromStateName)
		{
			OnEnter(fromStateName);
		}

		internal void Exit(string toStateName)
		{
			OnExit(toStateName);
		}
	}
}
