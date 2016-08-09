using System;

namespace GameWork.Interfacing.Interfaces
{
    public interface ISelectOptionInterface : IInterface
    {
        event Action<string> SelectedOptionEvent;

        void SetOptions(string[] options);
    }
}