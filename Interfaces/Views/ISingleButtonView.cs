using System;

namespace GameWork.Interfaces.Views
{
    public interface ISingleButtonView : IView
    {
        event Action ClickEvent;
    }
}