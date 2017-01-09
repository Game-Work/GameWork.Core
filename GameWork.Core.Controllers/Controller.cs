namespace GameWork.Core.Controllers
{
	public abstract class Controller
	{
		public virtual bool IsActive { get; private set; }

		public virtual void OnInitialize()
		{			
		}

		public virtual void Activate()
		{
			IsActive = true;
		}

		public virtual void OnTick(float deltaTime)
		{
		}

		public virtual void Deactivate()
		{
			IsActive = false;
		}

		public virtual void OnTerminate()
		{
			if(!IsActive)
			{
				Deactivate();
			}
		}
	}
}