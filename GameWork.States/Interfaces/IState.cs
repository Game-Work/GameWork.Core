using GameWork.Interfaces;
using System;

namespace GameWork.States.Interfaces
{
	public interface IState : IInitializable, IEnterable
	{
		string Name { get; }

		bool IsActive { get; }

		event Action<string> ChangeStateEvent;

		void ChangeState(string toStateName);
	}
}