using System;

namespace GameWork.States.Interfaces
{
	public interface IState
	{
		string Name { get; }

		event Action<string> ChangeState;

		void Enter();

		void Exit();

		void Tick(float deltaTime);
	}
}