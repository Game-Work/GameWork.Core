using GameWork.Core.States.Interfaces;

namespace GameWork.Core.States
{
	public abstract class State : State<IStateTransition>
	{
		protected State(params IStateTransition[] stateTransitions) : base(stateTransitions)
		{
		}
	}

	public abstract class State<TStateTransition> : IState
		where TStateTransition : IStateTransition
	{
		public abstract string Name { get; }

		public bool IsActive { get; private set; }

		protected readonly TStateTransition[] StateTransitions;

		protected State(params TStateTransition[] stateTransitions)
		{
			StateTransitions = stateTransitions;
		}

		public virtual void Initialize()
		{
		}

		public virtual void Terminate()
		{
		}

		public virtual void Enter()
		{
			IsActive = true;
		}

		public virtual void Exit()
		{
			IsActive = false;
		}
	}
}