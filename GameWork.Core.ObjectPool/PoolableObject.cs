﻿using GameWork.Core.ObjectPool.Interfaces;

namespace GameWork.Core.ObjectPool
{
    public abstract class PoolableObject : IPoolableObject
    {
        public bool IsTaken { get; private set; }
        
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