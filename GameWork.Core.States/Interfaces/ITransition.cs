namespace GameWork.Core.States.Interfaces
{
    public interface ITransition
    {
        bool IsConditionMet { get; }

        void OnConditionMet();
    }
}
