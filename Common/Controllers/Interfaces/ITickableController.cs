namespace GameWork.Common.Controllers.Interfaces
{
    public interface ITickableController : IController
    {
        void Tick(float deltaTime);
    }
}