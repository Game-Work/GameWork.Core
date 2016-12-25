namespace GameWork.Core.ObjectPool.Interfaces
{
    public interface IPoolableObject
    {
        bool IsTaken { get; }

        void SetTaken();

        void Return();
    }
}
