using System.Collections.Generic;
using GameWork.Commands;
using GameWork.Commands.Interfaces;
using GameWork.Interfacing.Interfaces;

namespace GameWork.Interfacing
{
    public abstract class TickableStateInterface : StateInterface, ITickableStateInterface
    {
        public abstract void Tick(float deltaTime);
    }
}