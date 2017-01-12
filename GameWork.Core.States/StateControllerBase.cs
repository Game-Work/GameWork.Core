namespace GameWork.Core.States
{
	public abstract class StateControllerBase
	{
		protected StateControllerBase ParentController;

		public string ActiveStateName { protected set; get; }
		
		public abstract void Initialize(string startStateName);

		public abstract void Terminate();

		protected abstract void OnChangeState(string toStateName);

		public void SetParent(StateControllerBase parentController)
		{
			ParentController = parentController;
		}

		internal void ChangeState(string toStateName)
		{
			OnChangeState(toStateName);
		}
	}
}
