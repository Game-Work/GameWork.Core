namespace GameWork.Interfaces.Controllers
{
    public interface ITickableController : IController
    {
        void Tick(float deltaTime);
    }
}