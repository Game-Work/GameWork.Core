namespace GameWork.Core.States
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public abstract class State
	{
		public abstract string Name { get; }
		
		public bool IsActive { get; private set; }

		protected StateControllerBase StateController { get; private set; }
		
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

		internal void SetStateController(StateControllerBase stateController)
		{
			StateController = stateController;
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
			OnEnter();
			IsActive = true;
		}

		internal virtual void Exit(string toStateName)
		{
			OnExit();
			IsActive = false;
		}
	}
}