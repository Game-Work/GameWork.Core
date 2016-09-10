using System.Collections.Generic;
using GameWork.States.Interfaces;
using System;
using GameWork.Interfaces;

namespace GameWork.States
{
	public class StateController<TState> : IInitializable, ITickable
		where TState : IState
	{
		protected readonly Dictionary<string, TState> States  = new Dictionary<string, TState>();
		protected string ActiveState;
        
        public StateController(params TState[] states)
		{
			foreach (var state in states)
			{
				States.Add(state.Name, state);
			}
		}

		public void SetState(string name)
		{
			var newState = States[name];
			ActiveState = name;
			newState.ChangeStateEvent += ChangeState;
			newState.Enter();
		}

		public void ChangeState(string name)
		{
			var newState = States[name];
			var prevState = States[ActiveState];

			ActiveState = name;

			prevState.ChangeStateEvent -= ChangeState;
			newState.ChangeStateEvent += ChangeState;

			prevState.Exit();
			newState.Enter();
		}

		public void Tick(float deltaTime)
		{
			States[ActiveState].Tick(deltaTime);
		}

		public void Initialize()
		{
			foreach (var state in States.Values)
			{
				state.Initialize();
			}
		}

		public void Terminate()
		{
			foreach (var state in States.Values)
			{
				state.Terminate();
			}
		}
    }
}