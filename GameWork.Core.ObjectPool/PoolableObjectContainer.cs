﻿using GameWork.Core.ObjectPool.Interfaces;

namespace GameWork.Core.ObjectPool
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public class PoolableObjectContainer<TObject> : IPoolableObject
    {
        public TObject Object { get; }

        public bool IsTaken { get; private set;  }

        public PoolableObjectContainer(TObject @object)
        {
            Object = @object;
        }

        public virtual void SetTaken()
        {
            IsTaken = true;
        }

        public virtual void Return()
        {
            IsTaken = false;
        }
    }
}
