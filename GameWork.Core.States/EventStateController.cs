using GameWork.Core.States.Interfaces;

namespace GameWork.Core.States
{
	public class EventStateController : EventStateController<EventState>
	{
	}


	public class EventStateController<TState> : StateController<TState>
		where TState : EventState  
	{
		public EventStateController(IStateController parentController, params TState[] states) : base(parentController, states)
		{
		}

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