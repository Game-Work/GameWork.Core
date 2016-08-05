using System;
using GameWork.Interfaces.Controllers;
using GameWork.Interfaces.Views;
using GameWork.MVC.Models;

namespace GameWork.MVC.Controllers
{
    public class SingleButtonController : IController
    {
        public event Action ClickedEvent;

        private readonly OptionsModel _model;
        private readonly ISingleButtonView _view;

        public SingleButtonController(OptionsModel model, ISingleButtonView view)
        {
            _model = model;
            _view = view;

            _view.ClickEvent += OnClicked;
        }
        
        private void OnClicked()
        {
            ClickedEvent();
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