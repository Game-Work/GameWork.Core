using GameWork.Core.States.Interfaces;

namespace GameWork.Core.States
{
	public abstract class State : IState
	{
		public abstract string Name { get; }

		public bool IsActive { get; private set; }

	    private readonly IStateTransition[] _stateTransitions;

	    protected State(IStateTransition[] stateTransitions)
	    {
	        _stateTransitions = stateTransitions;
	    }

        public virtual void Initialize()
        {
        }

        public virtual void Terminate()
        {
        }

        public virtual void Enter()
		{
			IsActive = true;
		}

		public virtual void Exit()
		{
			IsActive = false;
		}

	    public virtual void Tick(float deltaTime)
	    {
	    }

	    public bool CheckTransitions(out string toStateName)
	    {
	        var didTransition = false;
	        toStateName = null;

	        foreach (var transition in _stateTransitions)
	        {
	            if (transition.IsConditionMet)
	            {
	                toStateName = transition.ToStateName;
	                didTransition = true;
	                break;
	            }
	        }

            return didTransition;
	    }
    }
}