﻿using GameWork.Core.Commands.Interfaces;
using GameWork.Core.States.Input;

namespace GameWork.Core.States.Tick.Input
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public abstract class TickStateInput : TickStateInput<TickState>
	{
	}

    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public abstract class TickStateInput<TState>  : StateInput<TState>
		where TState: TickState
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
