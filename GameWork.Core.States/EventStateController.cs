namespace GameWork.Core.States
{
	public class EventStateController: StateController<EventState>
	{
		public override void ChangeState(string toStateName)
		{
			if (ActiveStateIndex >= 0)
			{
				States[ActiveStateIndex].DisconnectTransisions(this);
			}

			base.ChangeState(toStateName);

			if (ActiveStateIndex >= 0)
			{
				States[ActiveStateIndex].ConnectTransitions(this);
			}
		}
	}
}