using GameWork.Core.States.Event;

namespace GameWork.Core.States.Tick
{
	public class TickStateController : TickStateController<TickState>
	{
		public TickStateController(params TickState[] states) : base(states)
		{
		}
	}

	public class TickStateController<TTickState> : EventStateController<TTickState>
		where TTickState : TickState
	{
		public TickStateController(params TTickState[] states) : base(states)
		{
		}

		public void Tick(float deltaTime)
		{
			string toStateName;
			if (States[ActiveStateIndex].CheckTransitions(out toStateName))
			{
				ChangeState(toStateName);
			}
			else
			{
				States[ActiveStateIndex].Tick(deltaTime);
			}
		}
	}
}