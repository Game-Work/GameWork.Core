using System;
using GameWork.Models;
using GameWork.Interfacing.Interfaces;

namespace GameWork.Interfacing.Controllers
{
    public class TimedController : IInterfaceController
    {
        private readonly DurationModel _model;
        private readonly IInterface _interface;
        private float _elapsedTime;

        public event Action TimedOutEvent;
        
        public TimedController(DurationModel model, IInterface interfaceImplementation)
        {
            _model = model;
            _interface = interfaceImplementation;
        }

        public void Tick(float deltaTime)
        {
            if (_model.Duration < _elapsedTime)
            {
                TimedOutEvent();
            }

            _elapsedTime += deltaTime;
        }

        public void Initialize()
        {
            _interface.Initialize();
        }

        public void Terminate()
        {
            _interface.Terminate();
        }

        public void Activate()
        {
            _interface.Activate();
        }

        public void Deactivate()
        {
            _interface.Deactivate();
        }
    }
}