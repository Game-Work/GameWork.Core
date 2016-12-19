namespace GameWork.Core.States.Interfaces
{
    public interface IStateTransition
    {
        string ToStateName { get; }

        bool IsConditionMet { get; }
    }
}
