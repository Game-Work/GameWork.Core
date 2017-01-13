using GameWork.Core.States.Tick;

namespace GameWork.Core.States.Tests.TestObjects
{
	public class TestStateTwo : TickState
	{
		public const string StateName = "Two";
        
        public override string Name
		{
			get { return StateName; }
		}
    }
}
