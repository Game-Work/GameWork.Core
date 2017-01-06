using GameWork.Core.States.Interfaces;

namespace GameWork.Core.States
{
	public class TickStateController : TickStateController<ITickState>
	{
	}


	public class TickStateController<TTickState> : StateController<TTickState>
		where TTickState : ITickState
	{
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