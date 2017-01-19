namespace GameWork.Core.Controllers
{
	public abstract class Controller
	{
		public virtual bool IsActive { get; private set; }

		public virtual void Initialize()
		{			
		}

		public virtual void Activate()
		{
			IsActive = true;
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