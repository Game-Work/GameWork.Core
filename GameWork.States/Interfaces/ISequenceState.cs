using GameWork.Commands.States.Interfaces;

namespace GameWork.States.Interfaces
{
	public interface ISequenceState : IState, INextStateAction, IPreviousStateAction
	{
	}
}
