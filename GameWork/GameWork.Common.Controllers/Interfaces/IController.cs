using GameWork.Interfaces;

namespace GameWork.Controllers.Interfaces
{
	public interface IController : IInitializable, IActivatable, ITickable
	{
	}
}