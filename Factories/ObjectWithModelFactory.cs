using System;
using System.Collections.Generic;
using GameWork.Models.Interfaces;
using GameWork.Interfacing.Interfaces;

namespace GameWork.Factories
{
    public class ObjectWithModelFactory<TObject, TModel>
        where TModel : IModel
    {
        protected readonly Dictionary<string, TModel> _models = new Dictionary<string, TModel>();

        public void AddModel(TModel model)
        {
            _models.Add(model.Id, model);
        }

        public virtual TObject Create(string modelId)
        {
            //var model = _models[modelId];
            IInterfaceModel model = null;
            return (TObject) Activator.CreateInstance(typeof(TObject), model);
        }
    }
}