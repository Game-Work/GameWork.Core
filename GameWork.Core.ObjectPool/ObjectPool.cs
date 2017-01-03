using System.Collections.Generic;
using System.Linq;
using GameWork.Core.ObjectPool.Interfaces;

namespace GameWork.Core.ObjectPool
{
    public class ObjectPool : ObjectPool<IPoolableObject>
    {   
    }

    public class ObjectPool<TPoolableObject> where TPoolableObject : IPoolableObject
    {
        protected readonly List<TPoolableObject> PoolableObjects = new List<TPoolableObject>();

        public ObjectPool(params TPoolableObject[] poolableObjects)
        {
            PoolableObjects.AddRange(poolableObjects);   
        }

        public virtual bool TryTake(out TPoolableObject poolableObject)
        {
            poolableObject = PoolableObjects.FirstOrDefault(p => !p.IsTaken);

            if (poolableObject == null)
            {
                return false;
            }

            poolableObject.SetTaken();
            return true;
        }
    }
}
