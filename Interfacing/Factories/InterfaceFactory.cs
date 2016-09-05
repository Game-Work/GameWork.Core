using System;
using GameWork.Interfacing.Interfaces;
using System.Collections.Generic;

namespace GameWork.Interfacing.Factories
{
    public class InterfaceFactory<TInterface, TInterfaceModel> : IInterfaceFactory
        where TInterface : IInterface
        where TInterfaceModel : IInterfaceModel
    {
        protected readonly Dictionary<string, TInterfaceModel> _models = new Dictionary<string, TInterfaceModel>();

        public virtual void AddModel(IInterfaceModel model)
        {
            _models.Add(model.Id, (TInterfaceModel)model);
        }
        
        public virtual IInterface Create(string id)
        {
            var model = _models[id];
            return (TInterface)Activator.CreateInstance(typeof(TInterface), model);
        }
    }
}