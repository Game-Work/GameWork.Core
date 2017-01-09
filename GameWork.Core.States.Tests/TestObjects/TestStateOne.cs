using GameWork.Core.States.Interfaces;
using GameWork.Core.States.Tick;
using GameWork.Core.States.Tick.Interfaces;

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
