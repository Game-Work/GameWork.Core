namespace GameWork.Core.States.Interfaces
{
    public interface ITickableStateTransition : IStateTransition
    {
        string ToStateName { get; }

        bool IsConditionMet { get; }
    }
}
