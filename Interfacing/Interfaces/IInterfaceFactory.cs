using GameWork.Interfacing.Interfaces;

namespace GameWork.Interfacing.Interfaces
{
    public interface IInterfaceFactory
    {
        IInterface Create(string id);
    }
}