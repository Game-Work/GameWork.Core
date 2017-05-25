using GameWork.Core.ObjectPool.Interfaces;

namespace GameWork.Core.ObjectPool
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
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