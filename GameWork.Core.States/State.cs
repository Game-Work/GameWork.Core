using System;
using GameWork.Core.States.Interfaces;

namespace GameWork.Core.States
{
	public abstract class State : IState
	{
		public abstract string Name { get; }

		public bool IsActive { get; private set; }

	    private readonly ITransition[] _transitions;

	    protected State(ITransition[] transitions)
	    {
	        _transitions = transitions;
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

	    public bool AnyTransitionDone()
	    {
	        var didTransition = false;

	        foreach (var transition in _transitions)
	        {
	            if (transition.IsConditionMet)
	            {
	                transition.OnConditionMet();
	                didTransition = true;
	                break;
	            }
	        }

            return didTransition;
	    }
    }
}