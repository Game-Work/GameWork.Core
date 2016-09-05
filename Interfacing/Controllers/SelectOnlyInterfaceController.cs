using GameWork.Models;
using GameWork.Interfacing.Interfaces;
using System;

namespace GameWork.Interfacing.Controllers
{
    public class SelectOnlyInterfaceController : IInterfaceController
    {
        public bool Selected { get; private set; }

        private readonly OptionsModel _model;
        private readonly ISelectOnlyInterface _interface;

        private bool _pendingSelected;

        public SelectOnlyInterfaceController(OptionsModel model, ISelectOnlyInterface interfaceImplementation)
        {
            _model = model;
            _interface = interfaceImplementation;
        }

        public void Tick(float deltaTime)
        {
            Selected = _pendingSelected;
            _pendingSelected = false;
        }

        public void Initialize()
        {
            _interface.SelectedEvent += OnSelected;
            _interface.Initialize();
        }

        public void Terminate()
        {
            _interface.SelectedEvent -= OnSelected;
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

        private void OnSelected()
        {
            _pendingSelected = true;
        }
    }
}