using System;

namespace GameWork.Core.States.Event
{
	public abstract class EventStateTransition
	{
		internal event Action<string> ChangeStateEvent;
		
		protected virtual void OnEnter()
		{
		}

		protected virtual void OnExit()
		{
		}

		protected void ChangeState(string toStateName)
		{
			ChangeStateEvent(toStateName);
		}

		internal void Enter()
		{
			OnEnter();
		}

		internal void Exit()
		{
			OnExit();
		}
	}
}
