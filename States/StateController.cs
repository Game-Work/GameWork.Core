using System.Collections.Generic;
using GameWork.Interfaces;
using GameWork.States.Interfaces;

namespace GameWork.States
{
    public class StateController : IController
    {
        private readonly Dictionary<string, IState> _states  = new Dictionary<string, IState>();
        private string _activeState;

        public StateController(params IState[] states)
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
            newState.ChangeStateEvent += ChangeState;
            newState.Enter();
        }

        public void ChangeState(string name)
        {
            var newState = _states[name];
            var prevState = _states[_activeState];

            _activeState = name;

            prevState.ChangeStateEvent -= ChangeState;
            newState.ChangeStateEvent += ChangeState;

            prevState.Exit();
            newState.Enter();
        }

        public void Tick(float deltaTime)
        {
            _states[_activeState].Tick(deltaTime);
        }

        public void Initialize()
        {
        }

        public void Terminate()
        {
            _states = null;
        }
    }
}