using System;
using GameWork.Core.States.Interfaces;

namespace GameWork.Core.States.CommandDrivenState
{
    public class Container : IState
    {
        private readonly State _state;
        private readonly CommandWriter _commandWriter;

        public Container(State state, CommandWriter commandWriter)
        {
            _state = state;
            _commandWriter = commandWriter;
        }

        public bool IsActive => _state.IsActive;

        public string Name => _state.Name;

        public bool CheckTransitions(out string toStateName)
        {
            return _state.CheckTransitions(out toStateName);
        }

        public void Enter()
        {
            _state.Enter();
            _commandWriter.Enter();
        }

        public void Exit()
        {
            _commandWriter.Exit();
            _state.Exit();
        }

        public void Initialize()
        {
            _state.Initialize();
            _commandWriter.Initialize();
        }

        public void Terminate()
        {
            _commandWriter.Terminate();
            _state.Terminate();
        }

        public void Tick(float deltaTime)
        {
            _commandWriter.Tick(deltaTime);
            _state.Tick(deltaTime);
        }
    }
}
