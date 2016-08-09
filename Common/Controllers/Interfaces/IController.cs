namespace GameWork.Common.Controllers.Interfaces
{
    public interface IController
    {
        void Initialize();

        void Terminate();

        void Tick(float deltaTime);
    }
}