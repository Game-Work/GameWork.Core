using GameWork.Core.States.Input;

namespace GameWork.Core.States.Event.Input
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public abstract class InputEventState : InputEventState<StateInput>
	{
		protected InputEventState(StateInput stateInput) : base(stateInput)
		{
		}
	}

    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
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