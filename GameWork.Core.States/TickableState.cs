using GameWork.Core.States.Interfaces;

namespace GameWork.Core.States
{
	public abstract class TickableState : State<ITickableStateTransition>
	{
		protected TickableState(params ITickableStateTransition[] stateTransitions) : base(stateTransitions)
		{
		}

		public bool CheckTransitions(out string toStateName)
		{
			var didTransition = false;
			toStateName = null;

			foreach (var transition in StateTransitions)
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