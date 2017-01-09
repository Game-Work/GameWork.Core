using GameWork.Core.States.Input;

namespace GameWork.Core.States.Event.Input
{
	public abstract class InputEventState : InputEventState<StateInput>
	{
		protected InputEventState(StateInput stateInput) : base(stateInput)
		{
		}
	}

	public abstract class InputEventState<TStateInput> : EventState
		where TStateInput : StateInput
	{
		internal readonly TStateInput StateInput;

		protected InputEventState(TStateInput stateInput)
		{
			StateInput = stateInput;
		}
	}
}