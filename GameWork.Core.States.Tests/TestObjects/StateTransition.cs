using GameWork.Core.States.Interfaces;

namespace GameWork.Core.States.Tests.TestObjects
{
    public class StateTransition : IStateTransition
    {
        private StateTransitionBlackboard _transitionBlackboard;

        public string ToStateName { get; private set; }

        public bool IsConditionMet
        {
            get { return ToStateName == _transitionBlackboard.ToStateName; }
        }

        public StateTransition(string toStateName, StateTransitionBlackboard transitionBlackboard)
        {
            ToStateName = toStateName;
            _transitionBlackboard = transitionBlackboard;
        }
    }
}
