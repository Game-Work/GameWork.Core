using System;

namespace GameWork.Core.States.Event
{
	public abstract class EventStateTransition
	{
		internal event Action<string> ChangeStateEvent;

		protected void ChangeState(string toStateName)
		{
			ChangeStateEvent.Invoke(toStateName);
		}
	}
}
