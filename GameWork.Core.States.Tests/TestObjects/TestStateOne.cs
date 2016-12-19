using GameWork.Core.States.Interfaces;

namespace GameWork.Core.States.Tests.TestObjects
{
	public class TestStateOne : State
	{
		public const string StateName = "One";

        public override string Name
        {
            get { return StateName; }
        }

        public TestStateOne(IStateTransition[] stateTransitions) : base(stateTransitions)
        {
        }
	}
}
