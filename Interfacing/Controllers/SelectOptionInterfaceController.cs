using GameWork.Models;
using GameWork.Interfacing.Interfaces;

namespace GameWork.Interfacing.Controllers
{
    public class SelectOptionInterfaceController : IInterfaceController
    {
        public string Selected { get; private set; }

        private readonly OptionsModel _model;
        private readonly ISelectOptionInterface _interface;

        private string _pendingSelected;

        public SelectOptionInterfaceController(OptionsModel model, ISelectOptionInterface interfaceImplementation)
        {
            _model = model;
            _interface = interfaceImplementation;
        }

        public void Tick(float deltaTime)
        {
            Selected = _pendingSelected;
            _pendingSelected = null;
        }
        private void OnSelected(string selected)
        {
            _pendingSelected = selected;
        }

        public void Initialize()
        {
            _interface.Initialize();
            _interface.SetOptions(_model.Options);
            _interface.SelectedOptionEvent += OnSelected;
        }

        public void Terminate()
        {
            _interface.SelectedOptionEvent -= OnSelected;
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