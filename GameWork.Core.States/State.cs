namespace GameWork.Core.States
{
	public abstract class State
	{
		public abstract string Name { get; }
		
		public bool IsActive { get; private set; }
		
		protected virtual void OnInitialize()
		{
		}

		protected virtual void OnTerminate()
		{
		}

		protected virtual void OnEnter(string fromStateName)
		{
		}

		protected virtual void OnExit(string toStateName)
		{
		}

		internal virtual void Initialize()
		{
			OnInitialize();
		}

		internal virtual void Terminate()
		{
			OnTerminate();
		}

		internal virtual void Enter(string fromStateName)
		{
			OnEnter(fromStateName);
			IsActive = true;
		}

		internal virtual void Exit(string toStateName)
		{
			OnExit(toStateName);
			IsActive = false;
		}
	}
}