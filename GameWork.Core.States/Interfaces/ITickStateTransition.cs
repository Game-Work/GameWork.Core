namespace GameWork.Core.States.Interfaces
{
    public interface ITickStateTransition
    {
        string ToStateName { get; }

        bool IsConditionMet { get; }
    }
}
