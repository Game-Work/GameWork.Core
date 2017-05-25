using GameWork.Core.Math.Types;

namespace GameWork.Core.Components.Interfaces
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public interface ITransform : IComponent
    {
        Vector3 Position { get; set; }
    }
}
