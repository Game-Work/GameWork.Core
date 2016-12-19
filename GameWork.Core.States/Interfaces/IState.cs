using GameWork.Core.Interfaces;

namespace GameWork.Core.States.Interfaces
{
	public interface IState : IInitializable, IEnterable, ITickable
	{
		string Name { get; }

		bool IsActive { get; }

	    bool CheckTransitions(out string toStateName);
	}
}