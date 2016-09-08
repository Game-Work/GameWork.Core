using System;
using GameWork.States.Interfaces;

namespace GameWork.States
{
	public abstract class State : IState
	{
		public abstract string Name { get; }

		public event Action<string> ChangeStateEvent;

		public void ChangeState(string toStateName)
		{
			ChangeStateEvent(toStateName);
		}

		public abstract void Enter();

		public abstract void Exit();

		public abstract void Tick(float deltaTime);

		public virtual void Initialize()
		{

		}

		public virtual void Terminate()
		{

		}
	}
}