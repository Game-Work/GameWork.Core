using GameWork.Core.Commands.Interfaces;
using GameWork.Core.States.Tick.Interfaces;

namespace GameWork.Core.States.Tick.Input
{
    public abstract class InputTickStateTransition : ITickStateTransition
    {
        public abstract string ToStateName { get; }

		public abstract bool IsConditionMet { get; }

		protected ICommandQueueTake CommandQueue { get; private set; }

	    internal void SetCommandQueue(ICommandQueueTake commandQueue)
	    {
		    CommandQueue = commandQueue;
	    }
    }
}
