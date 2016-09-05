using System;
using System.Collections.Generic;
using GameWork.Interfacing.Interfaces;
using GameWork.Models.Interfaces;

namespace GameWork.Interfacing.Factories
{
    public class InterfaceControllerFactory<TController, TModel, TInterfaceFactory>
        where TController : IInterfaceController
        where TModel : IModel
        where TInterfaceFactory : IInterfaceFactory
    {
        private readonly Dictionary<string, TModel> _models = new Dictionary<string, TModel>();
        private readonly TInterfaceFactory _interfaceFactory;

        public InterfaceControllerFactory(TInterfaceFactory interfaceFactory)
        {
            _interfaceFactory = interfaceFactory;
        }

        public void AddModel(TModel model)
        {
            _models[model.Id] = model;
        }

        public TController Create(string modelId)
        {
            var model = _models[modelId];
            var interfaceImplementation = _interfaceFactory.Create(model.Id);
            return (TController)Activator.CreateInstance(typeof(TController), model, interfaceImplementation);
        }
    }
}