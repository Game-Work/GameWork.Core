using GameWork.Commands.Interfaces;
using GameWork.Interfaces;

namespace GameWork.Interfacing.Interfaces
{
    public interface IStateQueue : IInitializable, IEnterable, ICommandQueue
    {
    }
}
