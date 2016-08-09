using GameWork.Common.Controllers.Interfaces;

namespace GameWork.Interfacing.Interfaces
{
    public interface IInterfaceController : IController
    {
        void Activate();

        void Deactivate();
    }
}