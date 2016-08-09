using System;

namespace GameWork.Interfacing.Interfaces
{
    public interface ISelectOnlyInterface : IInterface
    {
        event Action SelectedEvent;
    }
}