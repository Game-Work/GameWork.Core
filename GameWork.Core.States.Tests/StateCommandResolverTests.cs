using System;
using System.Linq;
using GameWork.Core.States.Commands;
using GameWork.Core.States.Interfaces;
using GameWork.Core.States.Tests.TestObjects;
using NUnit.Framework;

namespace GameWork.Core.States.Tests
{
	[TestFixture]
	public class StateCommandResolverTests
	{
	    private readonly StateTransitionBlackboard _stateTransitionBlackboard;
	    private readonly State[] _states;

        private StateController _stateController;
        private TestStateCommandResolver _commandResolver;

	    public StateCommandResolverTests()
	    {

            _stateTransitionBlackboard = new StateTransitionBlackboard();

            _states = new State[]
            {
                new TestStateOne(new IStateTransition[]
                {
                    new StateTransition(TestStateTwo.StateName, _stateTransitionBlackboard),
                }),

                new TestStateTwo(new IStateTransition[]
                {
                    new StateTransition(TestStateThree.StateName, _stateTransitionBlackboard), 
                }),

                new TestStateThree(new IStateTransition[]
                {
                    new StateTransition(TestStateOne.StateName, _stateTransitionBlackboard),
                })
            };
        }


        [SetUp]
	    public void Setup()
	    {
            _stateController = new StateController(_states);
            _commandResolver = new TestStateCommandResolver(_stateController);
        }

        [TestCase("One")]
        [TestCase("Two")]
        public void ChangeState(string toStateName)
        {
            // Arrange
            var command = new ChangeStateCommand(toStateName);
            var toState = _states.Single(s => s.Name == toStateName);
            var toStateIndex = Array.IndexOf(_states, toState);

            // Act
            _commandResolver.ProcessCommand(command);

            // Assert
            Assert.AreEqual(toStateIndex, _stateController.ActiveStateIndex);
        }


        [TestCase("One", "Two")]
		[TestCase("Two", "Three")]
		public void NextStateInSequence(string fromStateName, string toStateName)
		{
            // Arrange
			_stateController.ChangeState(fromStateName);
            var command = new NextStateInSequenceCommand();
            var toState = _states.Single(s => s.Name == toStateName);
            var toStateIndex = Array.IndexOf(_states, toState);

            // Act
            _commandResolver.ProcessCommand(command);

            // Assert
			Assert.AreEqual(toStateIndex, _stateController.ActiveStateIndex);
		}

		[TestCase("Two", "One")]
		[TestCase("Three", "Two")]
		public void PreviousStateInSequence(string fromStateName, string toStateName)
		{
            // Arrange
            _stateController.ChangeState(fromStateName);
            var command = new PreviousStateInSequenceCommand();
            var toState = _states.Single(s => s.Name == toStateName);
            var toStateIndex = Array.IndexOf(_states, toState);

            // Act
            _commandResolver.ProcessCommand(command);

            // Assert
            Assert.AreEqual(toStateIndex, _stateController.ActiveStateIndex);
        }

        [TestCase("One", "Two")]
        [TestCase("Two", "Three")]
        [TestCase("Three", "Three")]
        public void NextStateInHistory(string fromStateName, string toStateName)
        {
            // Arrange
            _stateController.ChangeState(fromStateName);
            _stateController.ChangeState(toStateName);
            
            _stateController.TryPreviousStateInHistory();

            var toState = _states.Single(s => s.Name == toStateName);
            var toStateIndex = Array.IndexOf(_states, toState);

            var command = new TryNextStateInHistoryCommand();

            // Act
            _commandResolver.ProcessCommand(command);

            // Assert
            Assert.AreEqual(toStateIndex, _stateController.ActiveStateIndex);
            Assert.AreEqual(1, _stateController.ActiveStateHistoryIndex);
        }

        [TestCase("One", "One")]
        [TestCase("Two", "One")]
        [TestCase("Three", "Two")]
        public void PreviousStateInHistory(string fromStateName, string toStateName)
        {
            // Arrange
            _stateController.ChangeState(toStateName);
            _stateController.ChangeState(fromStateName);

            var toState = _states.Single(s => s.Name == toStateName);
            var toStateIndex = Array.IndexOf(_states, toState);
            
            var command = new TryPreviousStateInHistoryCommand();
            
            // Act
            _commandResolver.ProcessCommand(command);

            // Assert
            Assert.AreEqual(toStateIndex, _stateController.ActiveStateIndex);
            Assert.AreEqual(0, _stateController.ActiveStateHistoryIndex);
        }

        [TestCase("One", "Two")]
        [TestCase("Two", "Three")]
        [TestCase("Three", "One")]
        public void Transition(string fromStateName, string toStateName)
	    {
            // Arrange
            _stateController.ChangeState(fromStateName);

            var toState = _states.Single(s => s.Name == toStateName);
            var toStateIndex = Array.IndexOf(_states, toState);

            _stateTransitionBlackboard.ToStateName = toStateName;

            // Act
            _stateController.Tick(0f);

            // Assert   
            Assert.AreEqual(toStateIndex, _stateController.ActiveStateIndex);
        }
    }
}