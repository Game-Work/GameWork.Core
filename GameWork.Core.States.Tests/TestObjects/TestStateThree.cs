using GameWork.Core.States.Interfaces;

namespace GameWork.Core.States.Tests.TestObjects
{
	public class TestStateThree : State
	{
		public const string StateName = "Three";

		public override string Name
		{
			get { return StateName; }
		}

        public TestStateThree(IStateTransition[] stateTransitions) : base(stateTransitions)
        {
        }
    }
}
