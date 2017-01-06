using GameWork.Core.States.Interfaces;

namespace GameWork.Core.States
{
	public class TickableStateController : TickableStateController<ITickableState>
	{
	}


	public class TickableStateController<TTickableState> : StateController<TTickableState>
		where TTickableState : ITickableState
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