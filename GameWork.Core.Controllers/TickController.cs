namespace GameWork.Core.Controllers
{
	public abstract class TickController : Controller
	{
		public abstract void Tick(float deltaTime);
	}
}
