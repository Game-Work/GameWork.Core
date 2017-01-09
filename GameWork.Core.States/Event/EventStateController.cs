namespace GameWork.Core.States.Event
{
	public class EventStateController : EventStateController<EventState>
	{
	}
	
	public class EventStateController<TState> : StateController<TState>
		where TState : EventState  
	{
		public EventStateController(params TState[] states) : base(states)
		{
		}

		public override void ChangeState(string toStateName)
		{
			if (ActiveStateIndex >= 0)
			{
				States[ActiveStateIndex].DisconnectTransisions(this);
			}

			base.ChangeState(toStateName);

			if (ActiveStateIndex >= 0)
			{
				States[ActiveStateIndex].ConnectTransitions(this);
			}
		}
	}
}