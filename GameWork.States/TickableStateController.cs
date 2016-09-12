using GameWork.States.Interfaces;
using GameWork.Interfaces;

namespace GameWork.States
{
    public class TickableStateController : TickableStateController<ITickableState>
    {
        public TickableStateController(params ITickableState[] states) : base(states)
        {
        }
    }

    public class TickableStateController<TTickableState> : StateController<TTickableState>, ITickable
        where TTickableState : ITickableState
    {
        public TickableStateController(params TTickableState[] states) : base(states)
        {
        }

        public void Tick(float deltaTime)
        {
            States[ActiveState].Tick(deltaTime);
        }
    }
}