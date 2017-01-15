namespace GameWork.Core.States.Tests.TestObjects
{
    public class TickStateTransition : States.Tick.TickStateTransition
    {
        private readonly StateTransitionBlackboard _transitionBlackboard;
	    private readonly string _toStateName;

        public TickStateTransition(string toStateName, StateTransitionBlackboard transitionBlackboard)
        {
            _toStateName = toStateName;
            _transitionBlackboard = transitionBlackboard;
        }

		protected override void OnTick(float deltaTime)
		{
			if (_toStateName == _transitionBlackboard.ToStateName)
			{
				ExitState(_toStateName);	
				EnterState(_toStateName);
			}
		}
	}
}
