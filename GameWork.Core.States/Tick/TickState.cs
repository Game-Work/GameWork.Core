using System.Collections.Generic;
using GameWork.Core.States.Event;

namespace GameWork.Core.States.Tick
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public abstract class TickState : EventState
	{
		private readonly List<TickStateTransition> _transitions = new List<TickStateTransition>();

		public void AddTransitions(params TickStateTransition[] stateTransitions)
		{
			_transitions.AddRange(stateTransitions);
			base.AddTransitions(stateTransitions);
		}
		
		protected virtual void OnTick(float deltaTime)
		{
		}
		
		internal virtual void Tick(float deltaTime)
		{
			OnTick(deltaTime);
		}

		internal void TickTransitions(float deltaTime)
		{
			foreach (var transition in _transitions)
			{
				if (transition.DidChangeState(deltaTime))
				{
					break;
				}
			}
		}
	}
}