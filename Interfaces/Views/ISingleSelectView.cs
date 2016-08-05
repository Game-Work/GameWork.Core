using System;

namespace GameWork.Interfaces.Views
{
    public interface ISingleSelectView : IView
    {
        /// <summary>
        /// Used to send the Id of the UI Element that was clicked.
        /// The Id should be set by the controller that originally set the 
        /// view to display.
        /// </summary>
        event Action<string> ClickEvent;
        
        void SetOptions(string[] options);
    }
}