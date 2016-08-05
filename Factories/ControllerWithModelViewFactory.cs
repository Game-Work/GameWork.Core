using System;
using System.Collections.Generic;
using GameWork.Interfaces.Controllers;
using GameWork.Interfaces.Models;
using GameWork.Interfaces.Views;

namespace GameWork.Factories
{
    public class ControllerWithModelViewFactory<TController, TModel, TViewFactory>
        where TController : IController
        where TModel : IModel
        where TViewFactory : IViewFactory
    {
        private readonly Dictionary<string, TModel> _models = new Dictionary<string, TModel>();
        private readonly TViewFactory _viewFactory;

        public ControllerWithModelViewFactory(TViewFactory viewFactory)
        {
            _viewFactory = viewFactory;
        }

        public void AddModel(TModel model)
        {
            _models[model.Id] = model;
        }

        public TController Create(string modelId)
        {
            var model = _models[modelId];
            var view = _viewFactory.Create(model.Id);
            return (TController)Activator.CreateInstance(typeof(TController), model, view);
        }
    }
}