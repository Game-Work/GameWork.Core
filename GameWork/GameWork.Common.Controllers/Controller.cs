using GameWork.Controllers.Interfaces;

namespace GameWork.Controllers
{
	public abstract class Controller : IController
	{
		public virtual bool IsActive { get; private set; }

		public virtual void Initialize()
		{			
		}

		public virtual void Activate()
		{
			IsActive = true;
		}

		public virtual void Tick(float deltaTime)
		{
		}

		public virtual void Deactivate()
		{
			IsActive = false;
		}

		public virtual void Terminate()
		{
			if(!IsActive)
			{
				Deactivate();
			}
		}
	}
}