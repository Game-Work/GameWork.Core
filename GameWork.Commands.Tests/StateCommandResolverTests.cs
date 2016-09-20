using GameWork.Commands.States;
using GameWork.Commands.Tests.TestObjects;
using GameWork.States.Controllers;
using NUnit.Framework;

namespace GameWork.Commands.Tests
{
	public class StateCommandResolverTests
	{
		private readonly SequenceStateController _stateController; 
		private readonly TestStateCommandResolver _commandResolver;

		public StateCommandResolverTests()
		{
			_stateController = new SequenceStateController(
				new TestStateOne(),
				new TestStateTwo(),
				new TestStateThree());

			_commandResolver = new TestStateCommandResolver(_stateController);
		}

		[TestCase("One", "Two")]
		[TestCase("Two", "Three")]
		[TestCase("Three", "Three")]
		public void NextState(string fromStateName, string toStateName)
		{
			_stateController.ChangeState(fromStateName);
			Assert.That(_stateController.CurrentStateName == fromStateName);

			var command = new NextStateCommand();
			_commandResolver.ProcessCommand(command);

			Assert.That(_stateController.CurrentStateName == toStateName);
		}

		[TestCase("One", "One")]
		[TestCase("Two", "One")]
		[TestCase("Three", "Two")]
		public void PreviousState(string fromStateName, string toStateName)
		{
			_stateController.ChangeState(fromStateName);
			Assert.That(_stateController.CurrentStateName == fromStateName);

			var command = new PreviousStateCommand();
			_commandResolver.ProcessCommand(command);

			Assert.That(_stateController.CurrentStateName == toStateName);
		}

		[TestCase("One")]
		[TestCase("Two")]
		[TestCase("Three")]
		public void ChangeState(string toStateName)
		{
			var command = new ChangeStateCommand(toStateName);
			_commandResolver.ProcessCommand(command);

			Assert.That(_stateController.CurrentStateName == toStateName);
		}
	}
}