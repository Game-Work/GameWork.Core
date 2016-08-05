using System;

namespace GameWork.Interfaces.Views
{
    public interface IMultiSelectView : IView
    {
        /// <summary>
        /// Used to send the Ids of the UI Elements that were clicked.
        /// The Ids should be set by the controller that originally set the 
        /// view to display.
        /// </summary>
        event Action<string[]> ClickEvent;

        void SetOptions(string[] options);
    }
}