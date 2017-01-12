using GameWork.Core.States.Tests.TestObjects;
using GameWork.Core.States.Tick;
using NUnit.Framework;

namespace GameWork.Core.States.Tests
{
	[TestFixture]
	public class StateTransitionTests
	{
		private readonly StateTransitionBlackboard _stateTransitionBlackboard;
		private readonly TickState[] _states;

		private TickStateController _stateController;

		public StateTransitionTests()
		{
			_stateTransitionBlackboard = new StateTransitionBlackboard();

			var testStateOne = new TestStateOne();
			testStateOne.AddTransitions(new TickStateTransition(TestStateTwo.StateName, _stateTransitionBlackboard));

			var testStateTwo = new TestStateTwo();
			testStateTwo.AddTransitions(new TickStateTransition(TestStateThree.StateName, _stateTransitionBlackboard));

			var testStateThree = new TestStateThree();
			testStateThree.AddTransitions(new TickStateTransition(TestStateOne.StateName, _stateTransitionBlackboard));

			_states = new TickState[]
			{
				testStateOne, testStateTwo, testStateThree
			};
		}

		[SetUp]
		public void Setup()
		{
			_stateController = new TickStateController(_states);
		}
	   
		[TestCase("One", "Two")]
		[TestCase("Two", "Three")]
		[TestCase("Three", "One")]
		public void TickTransition(string fromStateName, string toStateName)
		{
			// Arrange
			_stateController.Initialize(fromStateName);
			_stateTransitionBlackboard.ToStateName = toStateName;

			// Act
			_stateController.Tick(0f);

			// Assert   
			Assert.AreEqual(toStateName, _stateController.ActiveStateName);
		}
	}
}