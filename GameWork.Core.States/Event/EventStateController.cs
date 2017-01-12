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

		protected override void OnChangeState(string toStateName)
		{
			if (ActiveStateName != null)
			{
				States[ActiveStateName].DisconnectTransisions(this);
			}

			base.OnChangeState(toStateName);

			if (ActiveStateName != null)
			{
				States[ActiveStateName].ConnectTransitions(this);
			}
		}
	}
}