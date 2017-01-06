using GameWork.Core.Interfaces;

namespace GameWork.Core.States.Interfaces
{
	public interface IState : IInitializable, IEnterable
	{
		string Name { get; }

		bool IsActive { get; }
	}
}