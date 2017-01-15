namespace GameWork.Core.States
{
	public abstract class StateControllerBase
	{
		protected StateControllerBase ParentController;

		public abstract void ExitState(string toStateName);

		public abstract void EnterState(string toStateName);

		public void SetParent(StateControllerBase parentController)
		{
			ParentController = parentController;
		}
	}
}
