namespace GameWork.Core.States.Input
{
	public class StateInput : StateInput<State>
	{
	}
	
	public class StateInput<TState>
		where TState : State
	{
		protected TState State { get; private set; }

		internal void SetState(TState state)
		{
			State = state;
		}

		protected virtual void OnInitialize()
		{
		}

		protected virtual void OnTerminate()
		{
		}

		protected virtual void OnEnter()
		{
		}

		protected virtual void OnExit()
		{
		}

		internal void Initialize()
		{
			OnInitialize();
		}

		internal void Terminate()
		{
			OnTerminate();
		}

		internal void Enter(string fromStateName)
		{
			OnEnter();
		}

		internal void Exit(string toStateName)
		{
			OnExit();
		}
	}
}
