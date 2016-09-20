using GameWork.Commands.States.Interfaces;
using GameWork.States.Interfaces;

namespace GameWork.States.Controllers
{
	public class SequenceStateController : SequenceStateController<ISequenceState>
	{
		public SequenceStateController(params ISequenceState[] states) : base(states)
		{
		}
	}

	public class SequenceStateController<TSequenceState> : StateController<TSequenceState>, INextStateAction, IPreviousStateAction
		where TSequenceState : ISequenceState
	{
		public SequenceStateController(params TSequenceState[] states) : base(states)
		{
		}

		public void NextState()
		{
			States[CurrentStateName].NextState();
		}

		public void PreviousState()
		{
			States[CurrentStateName].PreviousState();
		}
	}
}
