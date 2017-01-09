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

		protected virtual void OnEnter()
		{
		}

		protected virtual void OnExit()
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

		internal virtual void Enter()
		{
			OnEnter();
			IsActive = true;
		}

		internal virtual void Exit()
		{
			OnExit();
			IsActive = false;
		}
	}
}