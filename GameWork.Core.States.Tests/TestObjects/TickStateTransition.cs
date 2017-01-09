using GameWork.Core.States.Tick.Interfaces;

namespace GameWork.Core.States.Tests.TestObjects
{
    public class TickStateTransition : ITickStateTransition
    {
        private StateTransitionBlackboard _transitionBlackboard;

        public string ToStateName { get; private set; }

        public bool IsConditionMet
        {
            get { return ToStateName == _transitionBlackboard.ToStateName; }
        }

        public TickStateTransition(string toStateName, StateTransitionBlackboard transitionBlackboard)
        {
            ToStateName = toStateName;
            _transitionBlackboard = transitionBlackboard;
        }
    }
}
