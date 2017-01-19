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
			if (LastActiveStateName != null)
			{
				States[LastActiveStateName].DisconnectTransisions(this);
			}

			if (States.ContainsKey(toStateName))
			{
				States[toStateName].ConnectTransitions(this);
			}

			base.EnterState(toStateName);
		}
	}
}