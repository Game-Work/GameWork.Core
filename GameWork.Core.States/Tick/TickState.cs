using System.Collections.Generic;
using GameWork.Core.States.Event;
using GameWork.Core.States.Tick.Interfaces;

namespace GameWork.Core.States.Tick
{
	public abstract class TickState : EventState
	{
		private readonly List<ITickStateTransition> _transitions = new List<ITickStateTransition>();

		public void AddTransitions(params ITickStateTransition[] stateTransitions)
		{
			_transitions.AddRange(stateTransitions);
		}
		
		protected virtual void OnTick(float deltaTime)
		{
		}

		internal override void Enter(string fromStateName)
		{
			base.Enter(fromStateName);
			_transitions.ForEach(t => OnEnter());
		}

		internal override void Exit(string toStateName)
		{
			_transitions.ForEach(t => OnExit());
			base.Exit(toStateName);
		}

		internal virtual void Tick(float deltaTime)
		{
			OnTick(deltaTime);
		}

		internal bool CheckTransitions(out string toStateName)
		{
			var didTransition = false;
			toStateName = null;

			foreach (var transition in _transitions)
			{
				if (transition.IsConditionMet)
				{
					toStateName = transition.ToStateName;
					didTransition = true;
					break;
				}
			}

			return didTransition;
		}
	}
}