using GameWork.Core.States.Interfaces;

namespace GameWork.Core.States
{
	public class TickStateController : TickStateController<TickState>
	{
		public TickStateController(IStateController parentController, params TickState[] states) : base(parentController, states)
		{
		}

		public TickStateController(params TickState[] states) : base(states)
		{
		}
	}

	public class TickStateController<TTickState> : StateController<TTickState>
		where TTickState : TickState
	{
		public TickStateController(IStateController parentController, params TTickState[] states) : base(parentController, states)
		{
		}

		public TickStateController(params TTickState[] states) : base(states)
		{
		}

		public virtual void Tick(float deltaTime)
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