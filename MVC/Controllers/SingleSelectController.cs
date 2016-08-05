using System;
using GameWork.Interfaces.Controllers;
using GameWork.Interfaces.Views;
using GameWork.MVC.Models;

namespace GameWork.MVC.Controllers
{
    public class SingleSelectController : IController
    {
        public event Action<string> SelectedEvent;

        private readonly OptionsModel _model;
        private readonly ISingleSelectView _view;

        public SingleSelectController(OptionsModel model, ISingleSelectView view)
        {
            _model = model;
            _view = view;

            _view.SetOptions(_model.Options);
            _view.ClickEvent += OnSelected;
        }
        
        private void OnSelected(string selectedId)
        {
            SelectedEvent(selectedId);
        }

        public void Activate()
        {
            _view.Initialize();
            _view.Show();
        }

        public void Deactivate()
        {
            _view.Terminate();
        }
    }
}