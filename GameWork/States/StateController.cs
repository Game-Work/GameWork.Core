using System;
using System.Collections.Generic;
using GameWork.States.Interfaces; 

namespace GameWork.States
{
	public class StateController
	{
		private readonly Dictionary<string, IState> _states = new Dictionary<string, IState>();
		private IState _currentState;

		public string CurrentStateName
		{
			get { return _currentState.Name; }
		}

		public StateController(params IState[] states)
		{
			foreach(var state in states)
			{
				AddState(state);
			}
		}

		public void Tick(float deltaTime)
		{
			_currentState.Tick(deltaTime);
		}

		public void SetState(string name)
		{
			CheckExists(name);

			_currentState = _states[name];
			_currentState.Enter();
		}

		private void AddState(IState state)
		{
			CheckDoesntExist(state.Name);

			_states[state.Name] = state;
			state.ChangeState += ChangeState;
		}

		private void ChangeState(string name)
		{
			CheckExists(name);

			_currentState.Exit();
			_currentState = _states[name];
			_currentState.Enter();
		}

		private void CheckExists(string name)
		{
			if(!_states.ContainsKey(name))
			{
				throw new Exception("There is no State with the name: \"" + name + "\"");
			}
		}

		private void CheckDoesntExist(string name)
		{
			if(_states.ContainsKey(name))
			{
				throw new Exception("There is already a State with the name: \"" + name + "\". You cannot have duplicate states.");
			}
		}
	}
}