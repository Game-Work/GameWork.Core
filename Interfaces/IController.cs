namespace GameWork.Interfaces
{
    public interface IController
    {
        void Initialize();

        void Terminate();

        void Tick(float deltaTime);
    }
}