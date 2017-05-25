using GameWork.Core.States.Event;

namespace GameWork.Core.States.Tick
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public class TickStateController : TickStateController<TickState>
	{
		public TickStateController(params TickState[] states) : base(states)
		{
		}
	}

    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public class TickStateController<TTickState> : EventStateController<TTickState>
		where TTickState : TickState
	{
		public TickStateController(params TTickState[] states) : base(states)
		{
		}
		
		public void Tick(float deltaTime)
		{
			if(!IsProcessingStateChange)
			{
				States[ActiveStateName].TickTransitions(deltaTime);
				States[ActiveStateName].Tick(deltaTime);
			}
		}
	}
}