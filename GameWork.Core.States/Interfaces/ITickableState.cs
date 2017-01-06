using GameWork.Core.Interfaces;

namespace GameWork.Core.States.Interfaces
{
	public interface ITickableState : IState, ITickable
	{
	    bool CheckTransitions(out string toStateName);
	}
}