using GameWork.Core.States.Interfaces;

namespace GameWork.Core.States
{
	public abstract class State : IState
	{
		public abstract string Name { get; }

		public bool IsActive { get; private set; }
		
		public virtual void Initialize()
		{
		}

		public virtual void Terminate()
		{
		}

		public virtual void Enter()
		{
			IsActive = true;
		}

		public virtual void Exit()
		{
			IsActive = false;
		}
	}
}