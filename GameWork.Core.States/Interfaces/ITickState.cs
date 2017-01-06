using GameWork.Core.Interfaces;

namespace GameWork.Core.States.Interfaces
{
	public interface ITickState : IState, ITickable
	{
	    bool CheckTransitions(out string toStateName);
	}
}