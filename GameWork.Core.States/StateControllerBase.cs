namespace GameWork.Core.States
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
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
