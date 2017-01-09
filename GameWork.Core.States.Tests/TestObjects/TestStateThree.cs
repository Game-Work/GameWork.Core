using GameWork.Core.States.Interfaces;

namespace GameWork.Core.States.Tests.TestObjects
{
	public class TestStateThree : TickState
	{
		public const string StateName = "Three";

		public override string Name
		{
			get { return StateName; }
		}

        public TestStateThree(ITickStateTransition[] stateTransitions) : base(stateTransitions)
        {
        }
    }
}
