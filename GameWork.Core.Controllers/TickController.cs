namespace GameWork.Core.Controllers
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public abstract class TickController : Controller
	{
		public abstract void Tick(float deltaTime);
	}
}
