using GameWork.Core.States.Tick;

namespace GameWork.Core.States.Tests.TestObjects
{
	public class TestStateOne : TickState
	{
		public const string StateName = "One";

		public override string Name
		{
			get { return StateName; }
		}
	}
}
