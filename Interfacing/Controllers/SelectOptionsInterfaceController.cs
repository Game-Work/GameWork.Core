using GameWork.Models;
using GameWork.Interfacing.Interfaces;

namespace GameWork.Interfacing.Controllers
{
    public class SelectOptionsInterfaceController : IInterfaceController
    {
        public string[] Selected { get; private set; }

        private readonly OptionsModel _model;
        private readonly ISelectOptionsInterface _interface;

        private string[] _pendingSelected;

        public SelectOptionsInterfaceController(OptionsModel model, ISelectOptionsInterface interfaceImplementation)
        {
            _model = model;
            _interface = interfaceImplementation;
        }

        public void Tick(float deltaTime)
        {
            Selected = _pendingSelected;
            _pendingSelected = null;
        }

        public void Initialize()
        {
            _interface.SetOptions(_model.Options);
            _interface.SelectedOptionsEvent += OnSelected;
            _interface.Initialize();
        }

        public void Terminate()
        {
            _interface.SelectedOptionsEvent -= OnSelected;
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

        private void OnSelected(string[] selected)
        {
            _pendingSelected = selected;
        }

    }
}