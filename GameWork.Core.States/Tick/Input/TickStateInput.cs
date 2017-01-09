using GameWork.Core.Commands.Interfaces;
using GameWork.Core.States.Input;

namespace GameWork.Core.States.Tick.Input
{
	public abstract class TickStateInput : StateInput<TickState>
	{
		protected ICommandQueueWrite CommandQueue;

		protected virtual void OnTick(float deltaTime)
		{
		}

		internal void SetCommandQueue(ICommandQueueWrite commandQueue)
		{
			CommandQueue = commandQueue;
		}

		internal void Tick(float deltaTime)
		{
			OnTick(deltaTime);
		}
	}
}
