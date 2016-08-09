using System;
using GameWork.Interfacing.Interfaces;

namespace GameWork.Interfacing.Factories
{
    public class InterfaceFactory<TInterface> : IInterfaceFactory
        where TInterface : IInterface
    {
        public IInterface Create(string id)
        {
            return (TInterface) Activator.CreateInstance(typeof(TInterface), id);
        }
    }
}