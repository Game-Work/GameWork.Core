namespace GameWork.Core.ObjectPool.Interfaces
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public interface IPoolableObject
    {
        bool IsTaken { get; }

        void SetTaken();

        void Return();
    }
}
