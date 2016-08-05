using System;
using System.Collections.Generic;
using GameWork.Interfaces.Controllers;

namespace GameWork.GameStates
{
    public class GameStateController : ITickableController
    {
        private readonly Dictionary<string, GameState> _states  = new Dictionary<string, GameState>();
        private string _activeState;

        public GameStateController(params GameState[] states)
        {
            foreach (var state in states)
            {
                _states.Add(state.Name, state);
            }
        }

        public void SetState(string name)
        {
            var newState = _states[name];
            _activeState = name;
            newState.ChangeStateEvent += OnChangeState;

            newState.Enter(null);
        }

        public void OnChangeState(string name)
        {
            var newState = _states[name];
            var prevState = _states[_activeState];

            _activeState = name;

            prevState.ChangeStateEvent -= OnChangeState;
            newState.ChangeStateEvent += OnChangeState;

            prevState.Exit(newState);
            newState.Enter(prevState);
        }

        public void Tick(float deltaTime)
        {
            _states[_activeState].Tick(deltaTime);
        }

        public void Activate()
        {
        }

        public void Deactivate()
        {
        }
    }
}