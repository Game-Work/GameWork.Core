using System;
using GameWork.Interfaces.Controllers;
using GameWork.Interfaces.Views;
using GameWork.MVC.Models;

namespace GameWork.MVC.Controllers
{
    public class TimedController : ITickableController
    {
        private readonly DurationModel _model;
        private readonly IView _view;
        private float _elapsedTime;

        public event Action TimedOutEvent;
        
        public TimedController(DurationModel model, IView view)
        {
            _model = model;
            _view = view;
        }

        public void Tick(float deltaTime)
        {
            if (_model.Duration < _elapsedTime)
            {
                TimedOutEvent();
            }

            _elapsedTime += deltaTime;
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