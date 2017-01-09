namespace GameWork.Core.States.Tick.Interfaces
{
	public interface ITickStateTransition
	{
		string ToStateName { get; }

		bool IsConditionMet { get; }
	}
}
