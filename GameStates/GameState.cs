using System;

namespace GameWork.GameStates
{
    public abstract class GameState
    {
        public abstract string Name { get; }

        public event Action<string> ChangeStateEvent;
        
        public virtual void Enter(GameState previousState)
        {
        }

        public virtual void Exit(GameState nextState)
        {
        }

        public virtual void Tick(float deltaTime)
        {
        }

        protected virtual void ChangeState(string state)
        {
            ChangeStateEvent(state);
        }
    }
}