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
		
		public override void EnterState(string toStateName)
		{
			if (ActiveStateName != null)
			{
				States[ActiveStateName].DisconnectTransisions(this);
			}

			States[toStateName].ConnectTransitions(this);

			base.EnterState(toStateName);
		}
	}
}