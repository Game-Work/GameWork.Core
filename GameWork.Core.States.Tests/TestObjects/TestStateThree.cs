using GameWork.Core.States.Tick;

namespace GameWork.Core.States.Tests.TestObjects
{
	public class TestStateThree : TickState
	{
		public const string StateName = "Three";

		public override string Name
		{
			get { return StateName; }
		}
    }
}
