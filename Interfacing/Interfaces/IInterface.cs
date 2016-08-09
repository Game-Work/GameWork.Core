namespace GameWork.Interfacing.Interfaces
{
    public interface IInterface
    {
        bool IsActive { get; }

        void Initialize();

        void Terminate();

        void Activate();

        void Deactivate();
    }
}