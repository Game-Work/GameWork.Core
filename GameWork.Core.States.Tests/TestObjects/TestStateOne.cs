using GameWork.Core.States.Interfaces;

namespace GameWork.Core.States.Tests.TestObjects
{
	public class TestStateOne : TickState
	{
		public const string StateName = "One";

        public override string Name
        {
            get { return StateName; }
        }

        public TestStateOne(ITickStateTransition[] stateTransitions) : base(stateTransitions)
        {
        }
	}
}
