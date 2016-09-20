using GameWork.Interfaces;
using GameWork.States.Interfaces;

namespace GameWork.States.Controllers
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