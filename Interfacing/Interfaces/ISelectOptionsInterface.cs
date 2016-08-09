using System;

namespace GameWork.Interfacing.Interfaces
{
    public interface ISelectOptionsInterface : IInterface
    {
        event Action<string[]> SelectedOptionsEvent;

        void SetOptions(string[] options);
    }
}