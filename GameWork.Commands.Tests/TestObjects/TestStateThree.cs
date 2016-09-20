using GameWork.States;

namespace GameWork.Commands.Tests.TestObjects
{
	public class TestStateThree : SequenceState
	{
		public const string StateName = "Three";

		public override string Name
		{
			get { return StateName; }
		}

		public override void Enter()
		{
		}

		public override void Exit()
		{
		}

		public override void NextState()
		{
		}

		public override void PreviousState()
		{
			ChangeState(TestStateTwo.StateName);
		}
	}
}
