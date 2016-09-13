using System;
using GameWork.Commands.States.Interfaces;
using GameWork.States.Interfaces;

namespace GameWork.States
{
	public abstract class State : IState, IChangeStateAction
	{
		public abstract string Name { get; }

		public event Action<string> ChangeStateEvent;

		public void ChangeState(string toStateName)
		{
			ChangeStateEvent(toStateName);
		}

		public abstract void Enter();

		public abstract void Exit();
		
		public virtual void Initialize()
		{

		}

		public virtual void Terminate()
		{

		}
	}
}