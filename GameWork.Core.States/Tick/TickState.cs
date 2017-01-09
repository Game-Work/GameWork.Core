using GameWork.Core.States.Tick.Interfaces;

namespace GameWork.Core.States.Tick
{
	public abstract class TickState : State
	{
		private ITickStateTransition[] _transitions;

		public void AddTransitions(params ITickStateTransition[] stateTransitions)
		{
			_transitions = stateTransitions;
		}

		protected virtual void OnTick(float deltaTime)
		{
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