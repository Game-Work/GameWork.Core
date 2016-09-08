using System;

namespace GameWork.States.Interfaces
{
	public interface IState
	{
		string Name { get; }

		event Action<string> ChangeStateEvent;

		void Enter();

		void Exit();

		void Initialize();

		void Terminate();

		void Tick(float deltaTime);

		void ChangeState(string toStateName);

		void NextState();

		void PreviousState();
	}
}