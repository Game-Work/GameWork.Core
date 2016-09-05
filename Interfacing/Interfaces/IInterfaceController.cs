using GameWork.Interfaces;

namespace GameWork.Interfacing.Interfaces
{
    [System.Obsolete("Use a GameStateInterface and IInterface type. The controller code for UI should go in the UI/Unity layer.")]
    public interface IInterfaceController : IController
    {
        void Activate();

        void Deactivate();
    }
}