namespace GameWork.States
{
    public abstract class SequenceState : State
    {
        public abstract void NextState();

        public abstract void PreviousState();
    }
}
