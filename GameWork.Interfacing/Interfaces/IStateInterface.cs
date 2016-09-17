using GameWork.Commands.Interfaces;
using GameWork.Interfaces;

namespace GameWork.Interfacing.Interfaces
{
    public interface IStateInterface : IInitializable, IEnterable, ICommandInterface
    {
    }
}
