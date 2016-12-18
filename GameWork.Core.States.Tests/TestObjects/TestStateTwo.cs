using GameWork.Core.States.Interfaces;

namespace GameWork.Core.States.Tests.TestObjects
{
	public class TestStateTwo : State
	{
		public const string StateName = "Two";
        
        public override string Name
		{
			get { return StateName; }
		}

        public TestStateTwo(ITransition[] transitions) : base(transitions)
        {
        }
    }
}
